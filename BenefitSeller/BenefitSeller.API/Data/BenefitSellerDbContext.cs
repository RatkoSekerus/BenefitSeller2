using BenefitSeller.API.Models;
using BenefitSeller.API.SeedData;
using Microsoft.EntityFrameworkCore;

namespace BenefitSeller.API.Data
{
    public class BenefitSellerDbContext: DbContext
    {
        public BenefitSellerDbContext(DbContextOptions dbContextOptions): base(dbContextOptions)
        {
            
        }

        public DbSet<Company> Companies { get; set; }

        public DbSet<Merchant> Merchants { get; set; }

        public DbSet<MerchantCategory> MerchantCategories { get; set; }

        public DbSet<MerchantCategoryGroup> MerchantCategoryGroups { get; set; }

        public DbSet<SubscriptionPlan> SubscriptionPlans { get; set; }

        public DbSet<Transaction> Transactions { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<UserCard> UserCards { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Transaction>()
                .Property(m => m.TransactionDate)
                .HasDefaultValue(DateTime.Now);

            modelBuilder.Entity<Transaction>()
                .Property(m => m.TransactionStatus)
                .HasDefaultValue(StatusOfTransaction.Failed);

            modelBuilder.Entity<UserCard>()
                .Property(m => m.Balance)
                .HasDefaultValue(0);

            DataSeeder.Seed(modelBuilder);
        }
    }
}
