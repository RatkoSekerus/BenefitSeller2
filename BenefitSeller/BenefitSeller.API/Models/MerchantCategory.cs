namespace BenefitSeller.API.Models
{
    public class MerchantCategory
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public Guid MerchantCategoryGroupId { get; set; }


        // navigation property
        public MerchantCategoryGroup MerchantCategoryGroup {  get; set; }
    }
}
