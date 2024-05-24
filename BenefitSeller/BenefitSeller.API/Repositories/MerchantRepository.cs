using BenefitSeller.API.Contracts;
using BenefitSeller.API.Data;
using BenefitSeller.API.Models;
using Microsoft.EntityFrameworkCore;

namespace BenefitSeller.API.Repositories
{
    public class MerchantRepository : IMerchantRepository
    {
        private readonly BenefitSellerDbContext dbContext;
        public MerchantRepository(BenefitSellerDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task<Merchant?> GetByIdAsync(Guid id)
        {
            return await dbContext.Merchants.Include("MerchantCategory").FirstOrDefaultAsync(merchant => merchant.Id == id);
        }

        public async Task UpdateAsync(Merchant merchant)
        {
            Merchant? existingMerchant = await dbContext.Merchants.FirstOrDefaultAsync(m => m.Id == merchant.Id);

            if (existingMerchant != null)
            {
                existingMerchant.Earnings = merchant.Earnings;
                await dbContext.SaveChangesAsync();
            }
        }
    }
}
