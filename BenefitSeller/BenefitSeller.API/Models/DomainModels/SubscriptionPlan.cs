using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BenefitSeller.API.Models.DomainModels
{
    /// <summary>
    /// Represents a subscription plan entity.
    /// </summary>
    [Table("subscriptionplan")]
    public class SubscriptionPlan
    {
        /// <summary>
        /// Gets or sets the unique identifier of the subscription plan.
        /// </summary>
        [Key]
        [Column("id")]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the name of the subscription plan.
        /// </summary>
        [Column("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the type of subscription.
        /// </summary>
        [Column("subscriptiontype")]
        public SubscriptionType SubscriptionType { get; set; }
    }
}
