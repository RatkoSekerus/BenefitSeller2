namespace BenefitSeller.API.Models
{
    public class User
    {
        public Guid Id { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public Guid SubscriptionPlanId { get; set; }

        public Guid CompanyId {  get; set; }


        // navigation properties
        public SubscriptionPlan SubscriptionPlan { get; set; }

        public Company Company { get; set; }

        public ICollection<UserCard> UserCards { get; set; }
    }
}
