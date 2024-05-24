using System.ComponentModel.DataAnnotations;

namespace BenefitSeller.API.ViewModels
{
    public class TransactionViewModel
    {
        public Guid Id { get; set; }

        [Required]
        [Range(1, 100)]
        public double? Amount { get; set; } = 0;

        public DateTime? TransactionDate { get; set; }

        [Required(ErrorMessage = "UserId is required")]
        public Guid? UserId { get; set; }

        [Required(ErrorMessage = "MerchantId is required")]
        public Guid? MerchantId { get; set; }
    }
}
