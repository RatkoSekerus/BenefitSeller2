namespace BenefitSeller.API.Models.DomainModels
{
    /// <summary>
    /// Represents a subscription plan entity.
    /// </summary>
    public class SubscriptionPlan
    {
        /// <summary>
        /// Gets or sets the unique identifier of the subscription plan.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the name of the subscription plan.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the type of subscription.
        /// </summary>
        public SubscriptionType SubscriptionType { get; set; }
    }
}
