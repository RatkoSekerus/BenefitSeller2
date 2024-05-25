using BenefitSeller.API.Contracts.RepositoryInterfaces;
using BenefitSeller.API.Data;
using BenefitSeller.API.Models;
using BenefitSeller.API.Models.DomainModels;
using Microsoft.EntityFrameworkCore;

namespace BenefitSeller.API.Repositories
{
    /// <summary>
    /// Represents a repository for performing operations on <see cref="Transaction"/> entities.
    /// </summary>
    public class TransactionsRepository: ITransactionsRepository
    {
        private readonly BenefitSellerDbContext dbContext;

        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionsRepository"/> class.
        /// </summary>
        /// <param name="dbContext"></param>
        public TransactionsRepository(BenefitSellerDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        /// <summary>
        /// Creates a new transaction asynchronously.
        /// </summary>
        /// <param name="transaction">The transaction to create.</param>
        /// <returns>A populated object of type <see cref="Transaction"/></returns>
        public async Task<Transaction> CreateAsync(Transaction transaction)
        {
            transaction.TransactionDate = DateTime.Now;
            await dbContext.Transactions.AddAsync(transaction);
            await dbContext.SaveChangesAsync();
            return transaction;
        }

        /// <summary>
        /// Retrieves all transactions asynchronously.
        /// </summary>
        /// <returns>A populated list of <see cref="Transaction"/> objects.</returns>
        public async Task<List<Transaction>> GetAllAsync()
        {
            return await dbContext.Transactions.Include("User").Include("Merchant").ToListAsync();
        }

        /// <summary>
        /// Retrieves transactions associated with a specific user asynchronously.
        /// </summary>
        /// <param name="id">The unique identifier of the user.</param>
        /// <param name="status">The status of the transactions to retrieve.</param>
        /// <param name="pageNumber">The page number if pagination is needed (default is 1).</param>
        /// <param name="pageSize">The page size if pagination is needed (default is 100).</param>
        /// <returns> A populated list of objects of type <see cref="Transaction"/></returns>
        public async Task<List<Transaction>> GetByUserIdAsync(Guid userId, StatusOfTransaction status, int pageNumber = 1, int pageSize = 100)
        {
            int skip = (pageNumber - 1) * pageSize;

            return await dbContext.Transactions
                .Where(transaction =>  transaction.UserId == userId && transaction.TransactionStatus == status)
                .Skip(skip).Take(pageSize)
                .ToListAsync();
                    
        }
    }
}
