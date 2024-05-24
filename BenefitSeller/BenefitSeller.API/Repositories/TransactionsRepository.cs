using BenefitSeller.API.Contracts;
using BenefitSeller.API.Data;
using BenefitSeller.API.Models;
using Microsoft.EntityFrameworkCore;

namespace BenefitSeller.API.Repositories
{
    public class TransactionsRepository: ITransactionsRepository
    {
        private readonly BenefitSellerDbContext dbContext;
        public TransactionsRepository(BenefitSellerDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<Transaction> CreateAsync(Transaction transaction)
        {
            transaction.TransactionDate = DateTime.Now;
            await dbContext.Transactions.AddAsync(transaction);
            await dbContext.SaveChangesAsync();
            return transaction;
        }

        public async Task<List<Transaction>> GetAllAsync()
        {
            return await dbContext.Transactions.Include("User").Include("Merchant").ToListAsync();
        }

        public async Task<List<Transaction>> GetByUserIdAsync(Guid userId, StatusOfTransaction status, int pageNumber = 1, int pageSize = 100)
        {
            int skip = (pageNumber - 1) * pageSize;

            return await dbContext.Transactions
                .Where(transaction =>  transaction.UserId == userId && transaction.TransactionStatus == status)
                .Skip(skip).Take(pageSize)
                .ToListAsync();
                    
        }
    }
}
