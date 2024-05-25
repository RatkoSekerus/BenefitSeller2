namespace BenefitSeller.API.Models.DomainModels
{
    /// <summary>
    /// Represents a merchant entity.
    /// </summary>
    public class Merchant
    {
        /// <summary>
        /// Gets or sets the unique identifier of the merchant.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the name of the merchant.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the earnings of the merchant.
        /// </summary>
        public double Earnings { get; set; } = 0;

        /// <summary>
        /// Gets or sets the discount percentage offered by the merchant.
        /// </summary>
        public double? DiscountPercentage { get; set; } = 0;

        /// <summary>
        /// Gets or sets the identifier of the merchant category to which the merchant belongs.
        /// </summary>
        public Guid MerchantCategoryId { get; set; }


        // navigation property
        public MerchantCategory MerchantCategory {  get; set; }
    }
}
