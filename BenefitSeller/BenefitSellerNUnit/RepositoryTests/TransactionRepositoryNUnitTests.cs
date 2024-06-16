using BenefitSeller.API.Models;
using BenefitSeller.API.Models.DomainModels;
using BenefitSeller.API.Repositories;
using BenefitSeller.API.Repositories.DbConnectionWrappers;
using FluentAssertions;
using Moq;
using NUnit.Framework;


namespace BenefitSellerNUnit.RepositoryTests
{
    [TestFixture]
    public class TransactionRepositoryNUnitTests
    {
        private Mock<IDbConnectionWrapper> dbConnectionWrapperMock;
        private TransactionsRepositoryDapper transactionRepository;
        private List<Transaction> transactions;
        private Transaction transaction;
        private int userId;
        private int merchantId;
        private int amount;
        private StatusOfTransaction status;

        [SetUp]
        public void SetUp()
        {
            dbConnectionWrapperMock = new Mock<IDbConnectionWrapper>();
            transactionRepository = new TransactionsRepositoryDapper(dbConnectionWrapperMock.Object);

            userId = 1;
            merchantId = 1;
            amount = 10;
            status = StatusOfTransaction.Success;

            transactions = new List<Transaction>
        {
            new Transaction { Id = 1, UserId = userId, MerchantId = merchantId, Amount = amount, TransactionStatus = status, TransactionDate = DateTime.UtcNow },
            new Transaction { Id = 2, UserId = userId, MerchantId = merchantId, Amount = amount, TransactionStatus = status, TransactionDate = DateTime.UtcNow.AddMinutes(-10) }
        };

            transaction = new Transaction
            {
                UserId = userId,
                MerchantId = merchantId,
                Amount = amount,
                TransactionStatus = status,
                TransactionDate = DateTime.UtcNow
            };
        }

        [Test]
        public async Task GetByUserIdAsync_ShouldReturnTransactions()
        {
            // Arrange
            dbConnectionWrapperMock.Setup(db => db.QueryAsync<Transaction>(
                    It.IsAny<string>(),
                    It.IsAny<object>())).ReturnsAsync(transactions);

            // Act
            var result = await transactionRepository.GetByUserIdAsync(userId, status);

            // Assert
            result.Should().HaveCount(2)
                .And.OnlyContain(transaction => transaction.UserId == userId)
                .And.OnlyContain(transaction => transaction.MerchantId == merchantId)
                .And.OnlyContain(transaction => transaction.Amount == amount)
                .And.OnlyContain(transaction => transaction.TransactionStatus == status);
        }

        [Test]
        public async Task GetAllAsync_ShouldReturnTransactions()
        {
            // Arrange
            dbConnectionWrapperMock.Setup(db => db.FindAsync<Transaction>()).ReturnsAsync(transactions);

            // Act
            var result = await transactionRepository.GetAllAsync();

            // Assert
            result.Should().HaveCount(2)
                .And.OnlyContain(transaction => transaction.UserId == userId)
                .And.OnlyContain(transaction => transaction.MerchantId == merchantId)
                .And.OnlyContain(transaction => transaction.Amount == amount)
                .And.OnlyContain(transaction => transaction.TransactionStatus == status);
        }

        [Test]
        public async Task CreateAsync_SuccesfullyCreatesTransaction()
        {
            // Arrange
            dbConnectionWrapperMock.Setup(db => db.ExecuteAsync(It.IsAny<string>(), It.IsAny<object>())).Returns(Task.CompletedTask);

            // Act
            await transactionRepository.CreateAsync(transaction);

            // Assert
            Assert.That(transactionRepository.CreateAsync(transaction).IsCompletedSuccessfully);
        }
    }
}

