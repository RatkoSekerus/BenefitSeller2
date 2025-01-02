using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BenefitSeller.API.Models.DomainModels
{
    /// <summary>
    /// Represents an admin user entity.
    /// </summary>
    [Table("users")]
    public class AdminUser
    {
        /// <summary>
        /// Gets or sets the unique identifier of the admin user.
        /// </summary>
        [Key]
        [Column("id")]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the username of the admin user.
        /// </summary>
        [Column("username")]
        public string UserName { get; set; }

        /// <summary>
        /// Gets or sets the password hash of the admin user.
        /// </summary>
        [Column("passwordhash")]
        public string PasswordHash { get; set; }

        /// <summary>
        /// Gets or salt of the admin user
        /// </summary>
        [Column("salt")]
        public string Salt { get; set; }

        /// <summary>
        /// Gets or sets role of the admin user
        /// </summary>
        [Column("role")]
        public string Role { get; set; }
    }
}
