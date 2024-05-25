using BenefitSeller.API.Contracts.RepositoryInterfaces;
using BenefitSeller.API.Data;
using BenefitSeller.API.Models.DomainModels;
using Microsoft.EntityFrameworkCore;

namespace BenefitSeller.API.Repositories
{
    /// <summary>
    /// Represents a repository for performing operations on <see cref="MerchantCategoryGroup"/> entities.
    /// </summary>
    public class MerchantCategoryGroupRepository : IMerchantCategoryGroupRepository
    {
        private readonly BenefitSellerDbContext dbContext;

        /// <summary>
        /// Initializes a new instance of the <see cref="MerchantCategoryGroupRepository"/> class.
        /// </summary>
        /// <param name="dbContext"></param>
        public MerchantCategoryGroupRepository(BenefitSellerDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        /// <summary>
        /// Retrieves a Merchant Category Group entity by its unique identifier.
        /// </summary>
        /// <param name="id">The unique identifier of the Merchant Category Group.</param>
        /// <returns>
        /// A populated object of type <see cref="MerchantCategoryGroup"/>, or null if no entity with the specified id is found.
        /// </returns>
        public async Task<MerchantCategoryGroup?> GetByIdAsync(Guid id)
        {
            return await dbContext.MerchantCategoryGroups.FirstOrDefaultAsync(c => c.Id == id);
        }
    }
}
