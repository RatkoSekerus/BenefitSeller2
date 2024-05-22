using System.ComponentModel;
using System.Transactions;

namespace BenefitSeller.API.Models
{
    public class Transaction
    {
        public Guid Id { get; set; }

        public double Amount { get; set; } = 10;

        public DateTime TransactionDate { get; set; } = DateTime.Now;

        public StatusOfTransaction TransactionStatus { get; set; } = StatusOfTransaction.Failed;

        public Guid UserId { get; set; }

        public Guid MerchantId { get; set; }


        // navigation properties
        public Merchant Merchant { get; set; }

        public User User { get; set; }
    }
}
