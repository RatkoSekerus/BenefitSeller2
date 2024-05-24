using BenefitSeller.API.Contracts;
using BenefitSeller.API.Data;
using BenefitSeller.API.Models;
using Microsoft.EntityFrameworkCore;

namespace BenefitSeller.API.Repositories
{
    public class CompanyRepository : ICompanyRepository
    {
        private readonly BenefitSellerDbContext dbContext;
        public CompanyRepository(BenefitSellerDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task<Company?> GetByIdAsync(Guid id)
        {
            return await dbContext.Companies.Include("MerchantCategoryGroups").FirstOrDefaultAsync(c => c.Id == id);
        }
    }
}
