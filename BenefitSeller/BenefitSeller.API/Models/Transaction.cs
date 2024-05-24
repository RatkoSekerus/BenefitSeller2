using System.ComponentModel;
using System.Transactions;

namespace BenefitSeller.API.Models
{
    /// <summary>
    /// Represents a transaction entity.
    /// </summary>
    public class Transaction
    {
        /// <summary>
        /// Gets or sets the unique identifier of the transaction.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the amount of the transaction.
        /// </summary>
        public double Amount { get; set; } = 10;

        /// <summary>
        /// Gets or sets the date and time of the transaction.
        /// </summary>
        public DateTime TransactionDate { get; set; } = DateTime.Now;

        /// <summary>
        /// Gets or sets the status of the transaction.
        /// </summary>
        public StatusOfTransaction TransactionStatus { get; set; } = StatusOfTransaction.Failed;

        /// <summary>
        /// Gets or sets the identifier of the user associated with the transaction.
        /// </summary>
        public Guid UserId { get; set; }

        /// <summary>
        /// Gets or sets the identifier of the merchant associated with the transaction.
        /// </summary>
        public Guid MerchantId { get; set; }


        // navigation properties
        public Merchant Merchant { get; set; }

        public User User { get; set; }
    }
}
