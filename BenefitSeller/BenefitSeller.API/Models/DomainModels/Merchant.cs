using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BenefitSeller.API.Models.DomainModels
{
    /// <summary>
    /// Represents a merchant entity.
    /// </summary>
    [Table("merchant")]
    public class Merchant
    {
        /// <summary>
        /// Gets or sets the unique identifier of the merchant.
        /// </summary>
        [Key]
        [Column("id")]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the name of the merchant.
        /// </summary>
        [Column("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the earnings of the merchant.
        /// </summary>
        [Column("earnings")]
        public decimal Earnings { get; set; } = 0;

        /// <summary>
        /// Gets or sets the discount percentage offered by the merchant.
        /// </summary>
        [Column("discountpercentage")] 
        public decimal? DiscountPercentage { get; set; } = 0;

        /// <summary>
        /// Gets or sets the identifier of the merchant category to which the merchant belongs.
        /// </summary>
        [ForeignKey(nameof(MerchantCategoryId))]
        [Column("merchantcategoryid")]
        public int MerchantCategoryId { get; set; }


        // navigation property
        [NotMapped]
        public MerchantCategory? MerchantCategory {  get; set; }
    }
}
