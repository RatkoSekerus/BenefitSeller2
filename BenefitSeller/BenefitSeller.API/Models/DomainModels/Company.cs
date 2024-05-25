namespace BenefitSeller.API.Models.DomainModels
{
    /// <summary>
    /// Represents a company entity.
    /// </summary>
    public class Company
    {
        /// <summary>
        /// Gets or sets the unique identifier of the company.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the name of the company.
        /// </summary>
        public string Name { get; set; }


        //navigation properties
        public ICollection<User> Users { get; set; }

        public ICollection<MerchantCategoryGroup> MerchantCategoryGroups { get; set; }
    }
}
