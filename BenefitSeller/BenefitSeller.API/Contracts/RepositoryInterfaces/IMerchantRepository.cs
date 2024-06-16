using BenefitSeller.API.Models.DomainModels;

namespace BenefitSeller.API.Contracts.RepositoryInterfaces
{
    /// <summary>
    /// Represents a repository for performing operations on <see cref="Merchant"/> entities.
    /// </summary>
    public interface IMerchantRepository
    {
        /// <summary>
        /// Retrieves a Merchant entity by its unique identifier.
        /// </summary>
        /// <param name="id">The unique identifier of the Merchant.</param>
        /// <returns>
        /// A populated object of type <see cref="Merchant"/>, or null if no Merchant with the specified id is found.
        /// </returns>
        Task<Merchant?> GetByIdAsync(int id);

        /// <summary>
        /// Updates an existing Merchant entity.
        /// </summary>
        /// <param name="merchant">The Merchant model containing updated information.</param>
        /// <returns>A task representing the asynchronous operation.</returns>
        Task UpdateAsync(Merchant merchant);
    }
}
