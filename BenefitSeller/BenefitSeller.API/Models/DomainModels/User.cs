namespace BenefitSeller.API.Models.DomainModels
{
    /// <summary>
    /// Represents a user entity.
    /// </summary>
    public class User
    {
        /// <summary>
        /// Gets or sets the unique identifier of the user.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the username of the user.
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// Gets or sets the balance of the user.
        /// </summary>
        public double Balance { get; set; } = 100;

        /// <summary>
        /// Gets or sets the identifier of the subscription plan associated with the user.
        /// </summary>
        public Guid SubscriptionPlanId { get; set; }

        /// <summary>
        /// Gets or sets the identifier of the company associated with the user.
        /// </summary>
        public Guid CompanyId {  get; set; }


        // navigation properties
        public SubscriptionPlan SubscriptionPlan { get; set; }

        public Company Company { get; set; }
    }
}
