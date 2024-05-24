using BenefitSeller.API.Models;

namespace BenefitSeller.API.Contracts
{
    /// <summary>
    /// Represents a repository for performing operations on <see cref="MerchantCategoryGroup"/> entities.
    /// </summary>
    public interface IMerchantCategoryGroupRepository
    {
        /// <summary>
        /// Retrieves a Merchant Category Group entity by its unique identifier.
        /// </summary>
        /// <param name="id">The unique identifier of the Merchant Category Group.</param>
        /// <returns>
        /// A populated object of type <see cref="MerchantCategoryGroup"/>, or null if no entity with the specified id is found.
        /// </returns>
        Task<MerchantCategoryGroup?> GetByIdAsync(Guid id);
    }
}
