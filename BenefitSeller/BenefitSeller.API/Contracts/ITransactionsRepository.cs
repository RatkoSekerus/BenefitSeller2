using BenefitSeller.API.Models;

namespace BenefitSeller.API.Contracts
{
    public interface ITransactionsRepository
    {
        Task<List<Transaction>> GetAllAsync();

        Task<Transaction> CreateAsync(Transaction transaction);
    }
}
