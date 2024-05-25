using BenefitSeller.API.Models.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenefitSellerMSTest
{
    [TestClass]
    public class TransactionsManagerMSTests
    {
        [TestMethod]
        public void CheckForDiscount_WithValidDiscount_ShouldApplyDiscount()
        {
            // Arrange
            double amount = 100;
            double expectedAmount = 90; // Assuming discount percentage is 10%
            var merchant = new Merchant { DiscountPercentage = 10 };

            // Act
            TransactionsManager.CheckForDiscount(ref amount, merchant);

            // Assert
            Assert.AreEqual(expectedAmount, amount);
        }

        [TestMethod]
        public void CheckForDiscount_WithInvalidDiscount_ShouldNotApplyDiscount()
        {
            // Arrange
            double amount = 100;
            double expectedAmount = 100; // No discount applied
            var merchant = new Merchant { DiscountPercentage = null }; // No discount percentage

            // Act
            TransactionsManager.CheckForDiscount(ref amount, merchant);

            // Assert
            Assert.AreEqual(expectedAmount, amount);
        }

        [TestMethod]
        public void CheckForDiscount_WithZeroDiscount_ShouldNotApplyDiscount()
        {
            // Arrange
            double amount = 100;
            double expectedAmount = 100; // No discount applied
            var merchant = new Merchant { DiscountPercentage = 0 }; // Zero discount percentage

            // Act
            TransactionsManager.CheckForDiscount(ref amount, merchant);

            // Assert
            Assert.AreEqual(expectedAmount, amount);
        }
    }
}
