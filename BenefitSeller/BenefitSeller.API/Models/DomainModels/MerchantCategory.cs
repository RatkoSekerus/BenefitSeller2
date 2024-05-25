namespace BenefitSeller.API.Models.DomainModels
{
    /// <summary>
    /// Represents a category of merchants.
    /// </summary>
    public class MerchantCategory
    {
        /// <summary>
        /// Gets or sets the unique identifier of the merchant category.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the name of the merchant category.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the identifier of the merchant category group to which the merchant category belongs.
        /// </summary>
        public Guid MerchantCategoryGroupId { get; set; }


        // navigation property
        public MerchantCategoryGroup MerchantCategoryGroup {  get; set; }
    }
}
