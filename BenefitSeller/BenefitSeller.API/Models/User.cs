namespace BenefitSeller.API.Models
{
    public class User
    {
        public Guid Id { get; set; }

        public string UserName { get; set; }

        public double Balance { get; set; } = 100;

        public Guid SubscriptionPlanId { get; set; }

        public Guid CompanyId {  get; set; }


        // navigation properties
        public SubscriptionPlan SubscriptionPlan { get; set; }

        public Company Company { get; set; }
    }
}
