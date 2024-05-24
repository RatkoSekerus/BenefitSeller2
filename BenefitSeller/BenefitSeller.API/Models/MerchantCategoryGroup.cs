namespace BenefitSeller.API.Models
{
    /// <summary>
    /// Represents a group of merchant categories.
    /// </summary>
    public class MerchantCategoryGroup
    {
        /// <summary>
        /// Gets or sets the unique identifier of the merchant category group.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the name of the merchant category group.
        /// </summary>
        public string Name { get; set; }


        // navigation property
        public ICollection<Company> Companies { get; set; }
    }
}
