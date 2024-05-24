using BenefitSeller.API.Models.DomainModels;
using BenefitSeller.API.Models;

namespace BenefitSeller.API.Contracts.RepositoryInterfaces
{
    /// <summary>
    /// Represents a repository for performing operations on <see cref="Transaction"/> entities.
    /// </summary>
    public interface ITransactionsRepository
    {
        /// <summary>
        /// Retrieves all transactions asynchronously.
        /// </summary>
        /// <returns>A populated list of <see cref="Transaction"/> objects.</returns>
        Task<List<Transaction>> GetAllAsync();

        /// <summary>
        /// Retrieves transactions associated with a specific user asynchronously.
        /// </summary>
        /// <param name="id">The unique identifier of the user.</param>
        /// <param name="status">The status of the transactions to retrieve.</param>
        /// <param name="pageNumber">The page number if pagination is needed (default is 1).</param>
        /// <param name="pageSize">The page size if pagination is needed (default is 100).</param>
        /// <returns> A populated list of objects of type <see cref="Transaction"/></returns>
        Task<List<Transaction>> GetByUserIdAsync(Guid id, StatusOfTransaction status, int pageNumber = 1, int pageSize = 100);

        /// <summary>
        /// Creates a new transaction asynchronously.
        /// </summary>
        /// <param name="transaction">The transaction to create.</param>
        /// <returns>A populated object of type <see cref="Transaction"/></returns>
        Task<Transaction> CreateAsync(Transaction transaction);
    }
}
