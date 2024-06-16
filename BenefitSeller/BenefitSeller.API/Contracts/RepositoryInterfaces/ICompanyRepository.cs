using BenefitSeller.API.Models.DomainModels;

namespace BenefitSeller.API.Contracts.RepositoryInterfaces
{
    /// <summary>
    /// Represents a repository for performing operations on <see cref="Company"/> entities.
    /// </summary>
    public interface ICompanyRepository
    {
        /// <summary>
        /// Retrieves a Company entity by its unique identifier.
        /// </summary>
        /// <param name="id">The unique identifier of the Company.</param>
        /// <returns>
        /// A populated object of type <see cref="Company"/>, or null if no Company with the specified id is found.
        /// </returns>
        Task<Company?> GetByIdAsync(int id);
    }
}
