using AutoMapper;
using BenefitSeller.API.Contracts.ManagerInterfaces;
using BenefitSeller.API.Contracts.RepositoryInterfaces;
using BenefitSeller.API.ManagerResults;
using BenefitSeller.API.Models.DomainModels;
using BenefitSeller.API.Models.ViewModels;
using BenefitSeller.API.Models;
using BenefitSeller.API.Validation;
using FluentValidation.Results;
using FluentValidation;

namespace BenefitSeller.API.Managers
{
    /// <summary>
    /// Manages transactions between users and merchants within the system.
    /// </summary>
    public class TransactionsManager : ITransactionsManager
    {
        #region Private fields
        private readonly ITransactionsRepository repository;
        private readonly IMapper mapper;
        private readonly IUserRepository userRepository;
        private readonly IMerchantRepository merchantRepository;
        private readonly ICompanyRepository companyRepository;
        private readonly IMerchantCategoryGroupRepository merchantCategoryGroupRepository;
        #endregion

        #region Constructor
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionsManager"/> class.
        /// </summary>
        /// <param name="repository">The repository for transactions.</param>
        /// <param name="userRepository">The repository for users.</param>
        /// <param name="mapper">The mapper for mapping between objects.</param>
        /// <param name="merchantRepository">The repository for merchants.</param>
        /// <param name="companyRepository">The repository for companies.</param>
        /// <param name="merchantCategoryGroupRepository">The repository for merchant category groups.</param>
        public TransactionsManager(
            ITransactionsRepository repository,
            IUserRepository userRepository,
            IMapper mapper,
            IMerchantRepository merchantRepository,
            ICompanyRepository companyRepository,
            IMerchantCategoryGroupRepository merchantCategoryGroupRepository)
        {
            this.repository = repository;
            this.userRepository = userRepository;
            this.mapper = mapper;
            this.merchantRepository = merchantRepository;
            this.companyRepository = companyRepository;
            this.merchantCategoryGroupRepository = merchantCategoryGroupRepository;
        }
        #endregion

        #region ITransactionManager Implementation
        /// <summary>
        /// Create a transaction
        /// </summary>
        /// <param name="transaction">Transaction model</param>
        /// <returns>Information if transaction is successful</returns>
        public async Task<TransactionResult> CreateAsync(TransactionViewModel transaction)
        {
            TransactionResult res = new TransactionResult();
            Transaction resultTransaction = mapper.Map<Transaction>(transaction);

            bool SaveToDatabase = false;
            try
            {
                ValidateTransaction(transaction);

                User? user = await GetUserByIdAsync((int)transaction.UserId);
                Merchant? merchant = await GetMerchantByIdAsync((int)transaction.MerchantId);

                if (user == null || merchant == null)
                {
                    List<string> responseMessages = new List<string>();
                    if (user == null)
                    {
                        responseMessages.Add("User doesn't exist");
                    }
                    if (merchant == null)
                    {
                        responseMessages.Add("Merchant doesn't exist");
                    }

                    string ResponseMessage = string.Join(", ", responseMessages);

                    res.IsSuccess = false;
                    res.ResponseMessage = ResponseMessage;
                }
                else
                {
                    SaveToDatabase = true;
                    resultTransaction = await CheckTransaction(resultTransaction, user, merchant); 

                    res.IsSuccess = true;
                    res.ResponseMessage = "Transaction successfuly created";
                }
            }
            catch (Exception ex) when (ex is ValidationException || ex is InvalidOperationException)
            {
                res.IsSuccess = false;
                res.ResponseMessage = ex.Message;
            }
            catch (Exception e)
            {
                res.IsSuccess = false;
                res.ResponseMessage = "Transaction failed";
            }
            if (SaveToDatabase)
            {
                await repository.CreateAsync(resultTransaction);
            }
            return res;
        }

        /// <summary>
        /// Get transactions of the user
        /// </summary>
        /// <param name="userId">User Id</param>
        /// <param name="filterFailed">Set to true if getting failed transactions</param>
        /// <param name="pageNumber">Set page number if pagination needed</param>
        /// <param name="pageSize">Set page size if pagination needed</param>
        /// <returns>List of transactions</returns>
        public async Task<TransactionResult> GetAllByUserId(int userId, bool? filterFailed = false, int pageNumber = 1, int pageSize = 100)
        {
            TransactionResult res = new TransactionResult();
            User? user = await GetUserByIdAsync(userId);

            if (user != null)
            {
                StatusOfTransaction transactionStatus = filterFailed.HasValue && filterFailed.Value
                    ? StatusOfTransaction.Failed : StatusOfTransaction.Success;

                List<Transaction> transactions = await repository.GetByUserIdAsync(userId, transactionStatus, pageNumber, pageSize);

                res.Transactions = mapper.Map<List<TransactionViewModel>>(transactions);
                res.IsSuccess = true;
                res.ResponseMessage = filterFailed == true ? "Failed transactions" : "Successful transactions";
            }          
            else
            {
                res.IsSuccess = false;
                res.ResponseMessage = "User doesn't exist";
            }
            return res;
           
        }
        #endregion

        #region Private methods
        /// <summary>
        /// Checks if the transaction is valid based on user and merchant information.
        /// </summary>
        /// <param name="transaction">The transaction to be checked.</param>
        /// <returns>The validated transaction.</returns>
        private async Task<Transaction> CheckTransaction(Transaction transaction, User user, Merchant merchant)
        {
            transaction.Amount = Math.Round(ThrowExeptionIfBalanceInvalid(user, transaction, merchant),2);
            await ThrowExceptionIfSubscriptionInvalid(user, merchant);

            transaction.TransactionStatus = StatusOfTransaction.Success;
            await ChargeUser(user, merchant, transaction.Amount);
 
            return transaction;
        }

        /// <summary>
        /// Checks if the user's balance is sufficient for the transaction.
        /// </summary>
        /// <param name="user">The user.</param>
        /// <param name="transaction">The transaction to be checked.</param>
        /// <returns>True if the user's balance is sufficient; otherwise, false.</returns>
        private decimal ThrowExeptionIfBalanceInvalid(User user, Transaction transaction, Merchant merchant)
        {
            decimal amount = transaction.Amount;

            if (user.SubscriptionPlan.SubscriptionType == SubscriptionType.Platinum)
            {
                CheckForDiscount(ref amount, merchant);
            }

            if (user.Balance < amount)
            {
                throw new InvalidOperationException("Transaction amount exceeds user balance.");
            }

            return amount;
        }

        /// <summary>
        /// Checks if the user's subscription allows transactions with the merchant.
        /// </summary>
        /// <param name="user">The user.</param>
        /// <param name="merchant">The merchant.</param>
        /// <returns>True if the user's subscription allows transactions with the merchant; otherwise, false.</returns>
        private async Task ThrowExceptionIfSubscriptionInvalid(User user, Merchant merchant)
        {
            if(user.SubscriptionPlan.SubscriptionType == SubscriptionType.Standard)
            {
                Company? company = await companyRepository.GetByIdAsync(user.CompanyId);
                ICollection<MerchantCategoryGroup> companyCategoriesGroups = company.MerchantCategoryGroups;

                MerchantCategoryGroup? merchanCategoryGroup = await merchantCategoryGroupRepository.GetByIdAsync(merchant.MerchantCategory.MerchantCategoryGroupId);

                bool transacationAllowed = companyCategoriesGroups.Any(mcg => mcg.Name.Equals(merchanCategoryGroup?.Name));

                if (!transacationAllowed)
                {
                    throw new InvalidOperationException($"User subscription doesn't include the '{merchanCategoryGroup?.Name}'");
                }
            }
        }

        /// <summary>
        /// Charges the user for the transaction and updates user and merchant balances.
        /// </summary>
        /// <param name="user">The user.</param>
        /// <param name="merchant">The merchant.</param>
        /// <param name="amount">The transaction amount.</param>
        /// <returns>The charged amount.</returns>
        private async Task ChargeUser(User user, Merchant merchant, decimal amount)
        {
            amount = Math.Round(amount, 2);

            user.Balance -= amount;
            merchant.Earnings += amount;

            await userRepository.UpdateAsync(user);
            await merchantRepository.UpdateAsync(merchant);
        }

        /// <summary>
        /// Applies any applicable discount to the transaction amount.
        /// </summary>
        /// <param name="amount">The transaction amount.</param>
        /// <param name="merchant">The merchant.</param>
        private void CheckForDiscount(ref decimal amount, Merchant merchant) 
        {
            decimal? discountPercentage = merchant.DiscountPercentage;

            if (discountPercentage.HasValue && discountPercentage > 0)
            {
                amount = (decimal)(amount - (discountPercentage * (decimal)amount / 100));
            }
        }


        /// <summary>
        /// Finds user by id
        /// </summary>
        /// <param name="userId"></param>
        /// <returns>A populated object of type <see cref="User"/></returns>
        private async Task<User?> GetUserByIdAsync(int userId)
        {
            return await userRepository.GetByIdAsync(userId);

        }

        /// <summary>
        /// Finds merchant by id
        /// </summary>
        /// <param name="userId"></param>
        /// <returns>A populated object of type <see cref="Merchant"/></returns>
        private async Task<Merchant?> GetMerchantByIdAsync(int merchantId)
        {
            return await merchantRepository.GetByIdAsync(merchantId);

        }


        private void ValidateTransaction(TransactionViewModel transaction)
        {
            TransactionValidation transactionValidator = new TransactionValidation();
            transactionValidator.ValidateAndThrow(transaction);

        }
        #endregion

    }
}
