using System.ComponentModel.DataAnnotations;

namespace BenefitSeller.API.Models.ViewModels
{
    /// <summary>
    /// Represents a view model for a transaction.
    /// </summary>
    public class TransactionViewModel
    {
        /// <summary>
        /// Gets or sets the unique identifier of the transaction.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the amount of the transaction.
        /// </summary>
        [Required]
        [Range(1, 100)]
        public double? Amount { get; set; } = 0;

        /// <summary>
        /// Gets or sets the date and time of the transaction.
        /// </summary>
        public DateTime? TransactionDate { get; set; }

        /// <summary>
        /// Gets or sets the unique identifier of the user associated with the transaction.
        /// </summary>
        [Required(ErrorMessage = "UserId is required")]
        public int? UserId { get; set; }

        /// <summary>
        /// Gets or sets the unique identifier of the merchant associated with the transaction.
        /// </summary>
        [Required(ErrorMessage = "MerchantId is required")]
        public int? MerchantId { get; set; }
    }
}
