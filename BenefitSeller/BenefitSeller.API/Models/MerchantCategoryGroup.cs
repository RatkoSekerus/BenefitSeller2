namespace BenefitSeller.API.Models
{
    public class MerchantCategoryGroup
    {
        public Guid Id { get; set; }

        public string Name { get; set; }


        // navigation property
        public ICollection<Company> Companies { get; set; }
    }
}
