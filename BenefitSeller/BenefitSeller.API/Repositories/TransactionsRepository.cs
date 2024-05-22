using BenefitSeller.API.Contracts;
using BenefitSeller.API.Data;
using BenefitSeller.API.Models;
using Microsoft.EntityFrameworkCore;

namespace BenefitSeller.API.Repositories
{
    public class TransactionsRepository: ITransactionsRepository
    {
        private readonly BenefitSellerDbContext _dbContext;
        public TransactionsRepository(BenefitSellerDbContext dbContext)
        {
            this._dbContext = dbContext;
        }

        public async Task<Transaction> CreateAsync(Transaction transaction)
        {
            await _dbContext.Transactions.AddAsync(transaction);
            await _dbContext.SaveChangesAsync();
            return transaction;
        }

        public async Task<List<Transaction>> GetAllAsync()
        {
            return await _dbContext.Transactions.ToListAsync();
        }
    }
}
