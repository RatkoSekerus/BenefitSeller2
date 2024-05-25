using BenefitSeller.API.Contracts.RepositoryInterfaces;
using BenefitSeller.API.Data;
using BenefitSeller.API.Models.DomainModels;
using Microsoft.EntityFrameworkCore;

namespace BenefitSeller.API.Repositories
{
    /// <summary>
    /// Represents a repository for performing operations on <see cref="Merchant"/> entities.
    /// </summary>
    public class MerchantRepository : IMerchantRepository
    {
        private readonly BenefitSellerDbContext dbContext;

        /// <summary>
        /// Initializes a new instance of the <see cref="MerchantRepository"/> class.
        /// </summary>
        /// <param name="dbContext"></param>
        public MerchantRepository(BenefitSellerDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        /// <summary>
        /// Retrieves a Merchant entity by its unique identifier.
        /// </summary>
        /// <param name="id">The unique identifier of the Merchant.</param>
        /// <returns>
        /// A populated object of type <see cref="Merchant"/>, or null if no Merchant with the specified id is found.
        /// </returns>
        public async Task<Merchant?> GetByIdAsync(Guid id)
        {
            return await dbContext.Merchants.Include("MerchantCategory").FirstOrDefaultAsync(merchant => merchant.Id == id);
        }

        /// <summary>
        /// Updates an existing Merchant entity.
        /// </summary>
        /// <param name="merchant">The Merchant model containing updated information.</param>
        /// <returns>A task representing the asynchronous operation.</returns>
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
