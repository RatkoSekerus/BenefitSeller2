using BenefitSeller.API.Contracts.RepositoryInterfaces;
using BenefitSeller.API.Data;
using BenefitSeller.API.Models;
using BenefitSeller.API.Models.DomainModels;
using Microsoft.EntityFrameworkCore;

namespace BenefitSeller.API.Repositories
{
    /// <summary>
    /// Represents a repository for performing operations on <see cref="User"/> entities.
    /// </summary>
    public class UserRepository : IUserRepository
    {
        private readonly BenefitSellerDbContext dbContext;
        public UserRepository(BenefitSellerDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        /// <summary>
        /// Retrieves a user by its unique identifier asynchronously.
        /// </summary>
        /// <param name="id">The unique identifier of the user.</param>
        /// <returns>A populated object of type <see cref="User"/></returns>
        public async Task<User?> GetByIdAsync(Guid id)
        {
            return await dbContext.Users.Include("SubscriptionPlan").Include("Company").FirstOrDefaultAsync(user => user.Id == id);
        }

        /// <summary>
        /// Updates an existing user asynchronously.
        /// </summary>
        /// <returns>A task representing the asynchronous operation.</returns>
        public async Task UpdateAsync(User user)
        {
            User? existingUser = await dbContext.Users.FirstOrDefaultAsync(u => u.Id == user.Id);

            if (existingUser != null)
            {
                existingUser.Balance = user.Balance;
                await dbContext.SaveChangesAsync();
            }
        }
    }
}
