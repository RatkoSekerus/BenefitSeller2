using BenefitSeller.API.Models;
using BenefitSeller.API.Models.DomainModels;
using Microsoft.EntityFrameworkCore;

namespace BenefitSeller.API.SeedData
{
    public static class DataSeeder
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {

            // Define Subscription plan variables
            var standardSubscriptionPlanId = Guid.NewGuid();
            var premiumSubscriptionPlanId = Guid.NewGuid();
            var platinumSubscriptionPlanId = Guid.NewGuid();

            // Seed Subscription Plans
            modelBuilder.Entity<SubscriptionPlan>().HasData(
                new SubscriptionPlan { Id = standardSubscriptionPlanId, Name = "Standard", SubscriptionType = SubscriptionType.Standard },
                new SubscriptionPlan { Id = premiumSubscriptionPlanId, Name = "Premium", SubscriptionType = SubscriptionType.Premium },
                new SubscriptionPlan { Id = platinumSubscriptionPlanId, Name = "Platinum", SubscriptionType = SubscriptionType.Platinum }
            );

            // Define variables for MerchantCategoryGroups
            var foodAndDrinksId = Guid.NewGuid();
            var recreationId = Guid.NewGuid();
            var educationId = Guid.NewGuid();
            var cultureId = Guid.NewGuid();
            var travelingId = Guid.NewGuid();
            var shoppingId = Guid.NewGuid();

            var foodAndDrinks = new MerchantCategoryGroup { Id = foodAndDrinksId, Name = "Food and drinks" };
            var recreation = new MerchantCategoryGroup { Id = recreationId, Name = "Recreation" };
            var education = new MerchantCategoryGroup { Id = educationId, Name = "Education" };
            var culture = new MerchantCategoryGroup { Id = cultureId, Name = "Culture" };
            var traveling = new MerchantCategoryGroup { Id = travelingId, Name = "Traveling" };
            var shopping = new MerchantCategoryGroup { Id = shoppingId, Name = "Shopping" };

            //Seed Merchant Category Groups
            modelBuilder.Entity<MerchantCategoryGroup>().HasData(
                foodAndDrinks,
                recreation,
                education,
                culture,
                traveling,
                shopping
            );

            // Define variables for Companies
            var standardCompanyId = Guid.NewGuid();
            var premiumCompanyId = Guid.NewGuid();
            var platinumCompanyId = Guid.NewGuid();

            var Company1 = new Company { Id = standardCompanyId, Name = "Company with standard user"};
            var Company2 = new Company { Id = premiumCompanyId, Name = "Company with premium user" };
            var Company3 = new Company { Id = platinumCompanyId, Name = "Company with platinum user" };

            // Seed companies
            modelBuilder.Entity<Company>().HasData(
                Company1,
                Company2,
                Company3
            );

            // Define User variables
            var standardUserId = Guid.NewGuid();
            var premiumUserId = Guid.NewGuid();
            var platinumUserId = Guid.NewGuid();

            // Seed users
            modelBuilder.Entity<User>().HasData(
                new User { Id = standardUserId, UserName = "StandardUser", SubscriptionPlanId = standardSubscriptionPlanId, CompanyId = standardCompanyId },
                new User { Id = premiumUserId, UserName = "PremiumUser", SubscriptionPlanId = premiumSubscriptionPlanId, CompanyId = premiumCompanyId },
                new User { Id = platinumUserId, UserName = "PlatinumUser", SubscriptionPlanId = platinumSubscriptionPlanId, CompanyId = premiumCompanyId }
            );

            // Define variables for MerchantCategory Ids
            var restaurantsId = Guid.NewGuid();
            var coffeeShopsId = Guid.NewGuid();
            var fitnessId = Guid.NewGuid();
            var saunaId = Guid.NewGuid();
            var coursesId = Guid.NewGuid();
            var booksId = Guid.NewGuid();
            var conferencesId = Guid.NewGuid();
            var cinemaId = Guid.NewGuid();
            var museumId = Guid.NewGuid();
            var theaterId = Guid.NewGuid();
            var fuelId = Guid.NewGuid();
            var planeTicketsId = Guid.NewGuid();
            var trainOrBusTicketsId = Guid.NewGuid();
            var taxiId = Guid.NewGuid();

            // Declare MerchantCategory instances
            var restaurantsCategory = new MerchantCategory { Id = restaurantsId, Name = "Restaurants", MerchantCategoryGroupId = foodAndDrinksId };
            var coffeeShopsCategory = new MerchantCategory { Id = coffeeShopsId, Name = "Coffee shops", MerchantCategoryGroupId = foodAndDrinksId };
            var fitnessCategory = new MerchantCategory { Id = fitnessId, Name = "Fitness", MerchantCategoryGroupId = recreationId };
            var saunaCategory = new MerchantCategory { Id = saunaId, Name = "Sauna", MerchantCategoryGroupId = recreationId };
            var coursesCategory = new MerchantCategory { Id = coursesId, Name = "Courses", MerchantCategoryGroupId = educationId };
            var booksCategory = new MerchantCategory { Id = booksId, Name = "Books", MerchantCategoryGroupId = educationId };
            var conferencesCategory = new MerchantCategory { Id = conferencesId, Name = "Conferences", MerchantCategoryGroupId = educationId };
            var cinemaCategory = new MerchantCategory { Id = cinemaId, Name = "Cinema", MerchantCategoryGroupId = cultureId };
            var museumCategory = new MerchantCategory { Id = museumId, Name = "Museum", MerchantCategoryGroupId = cultureId };
            var theaterCategory = new MerchantCategory { Id = theaterId, Name = "Theater", MerchantCategoryGroupId = cultureId };
            var fuelCategory = new MerchantCategory { Id = fuelId, Name = "Fuel", MerchantCategoryGroupId = travelingId };
            var planeTicketsCategory = new MerchantCategory { Id = planeTicketsId, Name = "Plane tickets", MerchantCategoryGroupId = travelingId };
            var trainOrBusTicketsCategory = new MerchantCategory { Id = trainOrBusTicketsId, Name = "Train or bus tickets", MerchantCategoryGroupId = travelingId };
            var taxiCategory = new MerchantCategory { Id = taxiId, Name = "Taxi", MerchantCategoryGroupId = travelingId };

            // Configure HasData method
            modelBuilder.Entity<MerchantCategory>().HasData(
                restaurantsCategory,
                coffeeShopsCategory,
                fitnessCategory,
                saunaCategory,
                coursesCategory,
                booksCategory,
                conferencesCategory,
                cinemaCategory,
                museumCategory,
                theaterCategory,
                fuelCategory,
                planeTicketsCategory,
                trainOrBusTicketsCategory,
                taxiCategory
            );


            // Seed merchants
            modelBuilder.Entity<Merchant>().HasData(
                new Merchant { Id = Guid.NewGuid(), Name = "Merchant1", DiscountPercentage = 12.5, MerchantCategoryId = restaurantsId },
                new Merchant { Id = Guid.NewGuid(), Name = "Merchant2", DiscountPercentage = 7.5, MerchantCategoryId = coffeeShopsId },
                new Merchant { Id = Guid.NewGuid(), Name = "Merchant3", MerchantCategoryId = fitnessId },
                new Merchant { Id = Guid.NewGuid(), Name = "Merchant4", MerchantCategoryId = saunaId },
                new Merchant { Id = Guid.NewGuid(), Name = "Merchant5", MerchantCategoryId = coursesId },
                new Merchant { Id = Guid.NewGuid(), Name = "Merchant6", MerchantCategoryId = booksId }
            );

            modelBuilder.Entity<Company>()
                .HasMany(c => c.MerchantCategoryGroups)
                .WithMany(mc => mc.Companies)
                .UsingEntity(j => j.ToTable("CompanyBenefit")
                    .HasData(new[]
                    {
                        new { CompaniesId = standardCompanyId, MerchantCategoryGroupsId = foodAndDrinksId },
                        new { CompaniesId = standardCompanyId, MerchantCategoryGroupsId = recreationId },
                        new { CompaniesId = premiumCompanyId, MerchantCategoryGroupsId = educationId },
                        new { CompaniesId = premiumCompanyId, MerchantCategoryGroupsId = cultureId },
                        new { CompaniesId = platinumCompanyId, MerchantCategoryGroupsId = travelingId },
                        new { CompaniesId = platinumCompanyId, MerchantCategoryGroupsId = shoppingId },
                        new { CompaniesId = platinumCompanyId, MerchantCategoryGroupsId = foodAndDrinksId }
                    }
                ));
        }
    }
}

