using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BenefitSeller.API.Models.DomainModels
{
    /// <summary>
    /// Represents a company entity.
    /// </summary>
    [Table("company")]
    public class Company
    {
        /// <summary>
        /// Gets or sets the unique identifier of the company.
        /// </summary>
        [Key]
        [Column("id")]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the name of the company.
        /// </summary>
        [Column("name")]
        public string Name { get; set; }


        //navigation properties
        [NotMapped]
        public ICollection<User>? Users { get; set; }

        [NotMapped]
        public ICollection<MerchantCategoryGroup>? MerchantCategoryGroups { get; set; }
    }
}
