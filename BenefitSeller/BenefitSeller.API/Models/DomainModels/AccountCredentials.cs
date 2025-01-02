using System.ComponentModel.DataAnnotations;

namespace BenefitSeller.API.Models.DomainModels
{
    /// <summary>
    /// Represents a view model for a account.
    /// </summary>
    public class AccountCredentials
    {
        /// <summary>
        /// Gets or sets the user name
        /// </summary>
        [Required]
        [EmailAddress(ErrorMessage = "Invalid email address")]
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets the password
        /// </summary>
        [Required]
        public string Password { get; set; }
    }
}
