using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BenefitSeller.API.Models.DomainModels
{
    /// <summary>
    /// Represents a transaction entity.
    /// </summary>
    [Table("transactions")]
    public class Transaction
    {
        /// <summary>
        /// Gets or sets the unique identifier of the transaction.
        /// </summary>
        [Key]
        [Column("id")]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the amount of the transaction.
        /// </summary>
        [Column("amount")]
        public decimal Amount { get; set; } = 10;

        /// <summary>
        /// Gets or sets the date and time of the transaction.
        /// </summary>
        [Column("transactiondate")]
        public DateTime TransactionDate { get; set; } = DateTime.UtcNow;

        /// <summary>
        /// Gets or sets the status of the transaction.
        /// </summary>
        [Column("transactionstatus")]
        public StatusOfTransaction TransactionStatus { get; set; } = StatusOfTransaction.Failed;

        /// <summary>
        /// Gets or sets the identifier of the user associated with the transaction.
        /// </summary>
        [ForeignKey(nameof(UserId))]
        [Column("userid")]
        public int UserId { get; set; }

        /// <summary>
        /// Gets or sets the identifier of the merchant associated with the transaction.
        /// </summary>
        [ForeignKey(nameof(MerchantId))]
        [Column("merchantid")]
        public int MerchantId { get; set; }


        // navigation properties
        [NotMapped]
        public Merchant? Merchant { get; set; }

        [NotMapped]
        public User? User { get; set; }
    }
}
