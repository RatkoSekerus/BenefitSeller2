using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BenefitSeller.API.Models.DomainModels
{
    /// <summary>
    /// Represents a category of merchants.
    /// </summary>
    [Table("merchantcategory")]
    public class MerchantCategory
    {
        /// <summary>
        /// Gets or sets the unique identifier of the merchant category.
        /// </summary>
        [Key]
        [Column("id")]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the name of the merchant category.
        /// </summary>
        [Column("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the identifier of the merchant category group to which the merchant category belongs.
        /// </summary>
        [ForeignKey(nameof(MerchantCategoryGroupId))]
        [Column("merchantcategorygroupid")]
        public int MerchantCategoryGroupId { get; set; }


        // navigation property
        [NotMapped]
        public MerchantCategoryGroup? MerchantCategoryGroup {  get; set; }
    }
}
