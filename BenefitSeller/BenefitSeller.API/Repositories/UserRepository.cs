using BenefitSeller.API.Contracts;
using BenefitSeller.API.Data;
using BenefitSeller.API.Models;
using Microsoft.EntityFrameworkCore;

namespace BenefitSeller.API.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly BenefitSellerDbContext dbContext;
        public UserRepository(BenefitSellerDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task<User?> GetByIdAsync(Guid id)
        {
            return await dbContext.Users.Include("SubscriptionPlan").Include("Company").FirstOrDefaultAsync(user => user.Id == id);
        }

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
