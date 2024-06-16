using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BenefitSeller.API.Models.DomainModels
{
    /// <summary>
    /// Represents a group of merchant categories.
    /// </summary>
    [Table("merchantcategorygroup")]
    public class MerchantCategoryGroup
    {
        /// <summary>
        /// Gets or sets the unique identifier of the merchant category group.
        /// </summary>
        [Key]
        [Column("id")]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the name of the merchant category group.
        /// </summary>
        [Column("name")]
        public string Name { get; set; }


        // navigation property
        [NotMapped]
        public ICollection<Company>? Companies { get; set; }
    }
}
