using BenefitSeller.API.Models.ViewModels;
using FluentValidation;

namespace BenefitSeller.API.Validation
{
    public class TransactionValidation: AbstractValidator<TransactionViewModel>
    {
        private const int maximumNumberOfUsers = 100;
        private const int maximumNumberOfMerchants = 50;
        public TransactionValidation()
        {
            RuleFor(transaction => transaction.UserId).NotNull().WithMessage("Please provide UserId")
                .LessThanOrEqualTo(maximumNumberOfUsers)
                .WithMessage(transaction => $"UserId ({transaction.UserId}) cannot be above {maximumNumberOfUsers}");
            RuleFor(transaction => transaction.MerchantId).Must(merchantId => merchantId < maximumNumberOfMerchants)
                .WithMessage(transaction => $"MerchantId ({transaction.MerchantId}) cannot be above {maximumNumberOfMerchants}");
            RuleFor(transaction => transaction.TransactionDate).Null();
        }
    }
}
