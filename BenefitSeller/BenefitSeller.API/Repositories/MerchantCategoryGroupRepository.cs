using BenefitSeller.API.Contracts;
using BenefitSeller.API.Data;
using BenefitSeller.API.Models;
using Microsoft.EntityFrameworkCore;

namespace BenefitSeller.API.Repositories
{
    public class MerchantCategoryGroupRepository : IMerchantCategoryGroupRepository
    {
        private readonly BenefitSellerDbContext dbContext;
        public MerchantCategoryGroupRepository(BenefitSellerDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task<MerchantCategoryGroup?> GetByIdAsync(Guid id)
        {
            return await dbContext.MerchantCategoryGroups.FirstOrDefaultAsync(c => c.Id == id);
        }
    }
}
