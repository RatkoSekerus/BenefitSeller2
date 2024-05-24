using BenefitSeller.API.ManagerResults;
using BenefitSeller.API.Models;
using BenefitSeller.API.ViewModels;

namespace BenefitSeller.API.Contracts
{
    /// <summary>
    /// Represents a repository for performing operations on on <see cref="Transaction"/> entities.
    /// </summary>
    public interface ITransactionsManager
    {
        /// <summary>
        /// Retrieves transactions associated with a user.
        /// </summary>
        /// <param name="userId">The unique identifier of the user.</param>
        /// <param name="filterFailed">Set to true to retrieve failed transactions.</param>
        /// <param name="pageNumber">Specifies the page number if pagination is needed.</param>
        /// <param name="pageSize">Specifies the page size if pagination is needed.</param>
        /// <returns>A populated object of <see cref="TransactionResult"/>.</returns>
        Task<TransactionResult> GetAllByUserId(Guid userId, bool? filterFailed, int pageNumber, int pageSize);

        /// <summary>
        /// Creates a new transaction.
        /// </summary>
        /// <param name="transaction">The transaction model to be created.</param>
        /// <returns>A populated object of <see cref="TransactionResult"/>.</returns>
        Task<TransactionResult> CreateAsync(TransactionViewModel transaction);
    }
}
