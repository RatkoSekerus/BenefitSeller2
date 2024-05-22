namespace BenefitSeller.API.Models
{
    public class UserCard
    {
        public Guid Id { get; set; }

        public double Balance { get; set; }

        public Guid UserId { get; set; }


        // navigation property
        public User User {  get; set; }
    }
}
