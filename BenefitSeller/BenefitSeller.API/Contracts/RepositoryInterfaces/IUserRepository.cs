using BenefitSeller.API.Models.DomainModels;

namespace BenefitSeller.API.Contracts.RepositoryInterfaces
{
    /// <summary>
    /// Represents a repository for performing operations on <see cref="User"/> entities.
    /// </summary>
    public interface IUserRepository
    {
        /// <summary>
        /// Retrieves a user by its unique identifier asynchronously.
        /// </summary>
        /// <param name="id">The unique identifier of the user.</param>
        /// <returns>A populated object of type <see cref="User"/></returns>
        Task<User?> GetByIdAsync(int id);

        /// <summary>
        /// Updates an existing user asynchronously.
        /// </summary>
        /// <returns>A task representing the asynchronous operation.</returns>
        Task UpdateAsync(User user);
    }
}
