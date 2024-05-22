namespace BenefitSeller.API.Models
{
    public class Company
    {
        public Guid Id { get; set; }

        public string Name { get; set; }


        //navigation properties
        public ICollection<User> Users { get; set; }

        public ICollection<MerchantCategoryGroup> MerchantCategoryGroups { get; set; }
    }
}
