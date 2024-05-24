using BenefitSeller.API.Contracts;
using BenefitSeller.API.Data;
using BenefitSeller.API.Models;
using Microsoft.EntityFrameworkCore;

namespace BenefitSeller.API.Repositories
{
    /// <summary>
    /// Represents a repository for performing operations on <see cref="Company"/> entities.
    /// </summary>
    public class CompanyRepository : ICompanyRepository
    {
        private readonly BenefitSellerDbContext dbContext;

        /// <summary>
        /// Initializes a new instance of the <see cref="CompanyRepository"/> class.
        /// </summary>
        /// <param name="dbContext"></param>
        public CompanyRepository(BenefitSellerDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        /// <summary>
        /// Retrieves a Company entity by its unique identifier.
        /// </summary>
        /// <param name="id">The unique identifier of the Company.</param>
        /// <returns>
        /// A populated object of type <see cref="Company"/>, or null if no Company with the specified id is found.
        /// </returns>
        public async Task<Company?> GetByIdAsync(Guid id)
        {
            return await dbContext.Companies.Include("MerchantCategoryGroups").FirstOrDefaultAsync(c => c.Id == id);
        }
    }
}
