namespace BenefitSeller.API.Models
{
    public class Merchant
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public double Earnings {  get; set; }

        public double? DiscountPercentage { get; set; }

        public Guid MerchantCategoryId { get; set; }


        // navigation property
        public MerchantCategory MerchantCategory {  get; set; }
    }
}
