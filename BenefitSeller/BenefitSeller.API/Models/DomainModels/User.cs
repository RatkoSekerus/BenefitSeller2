using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BenefitSeller.API.Models.DomainModels
{
    /// <summary>
    /// Represents a user entity.
    /// </summary>
    [Table("users")]
    public class User
    {
        /// <summary>
        /// Gets or sets the unique identifier of the user.
        /// </summary>
        [Key]
        [Column("id")]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the username of the user.
        /// </summary>
        [Column("username")]
        public string UserName { get; set; }

        /// <summary>
        /// Gets or sets the balance of the user.
        /// </summary>
        [Column("balance")]
        public decimal Balance { get; set; } = 100;

        /// <summary>
        /// Gets or sets the identifier of the subscription plan associated with the user.
        /// </summary>
        [ForeignKey(nameof(SubscriptionPlanId))]
        [Column("subscriptionplanid")]
        public int SubscriptionPlanId { get; set; }

        /// <summary>
        /// Gets or sets the identifier of the company associated with the user.
        /// </summary>
        [ForeignKey(nameof(CompanyId))]
        [Column("companyid")]
        public int CompanyId {  get; set; }


        // navigation properties
        [NotMapped]
        public SubscriptionPlan? SubscriptionPlan { get; set; }

        [NotMapped]
        public Company? Company { get; set; }
    }
}
