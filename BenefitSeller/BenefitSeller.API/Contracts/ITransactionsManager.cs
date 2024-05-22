using BenefitSeller.API.Models;
using BenefitSeller.API.ViewModels;

namespace BenefitSeller.API.Contracts
{
    public interface ITransactionsManager
    {
        Task<List<Transaction>> GetAllAsync();

        Task<Boolean> CreateAsync(TransactionViewModel transaction);
    }
}
