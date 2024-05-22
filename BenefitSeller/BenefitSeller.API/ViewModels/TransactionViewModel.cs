using BenefitSeller.API.Models;

namespace BenefitSeller.API.ViewModels
{
    public class TransactionViewModel
    {
        public double Amount { get; set; } = 0;

        public Guid UserId { get; set; }

        public Guid MerchantId { get; set; }
    }
}
