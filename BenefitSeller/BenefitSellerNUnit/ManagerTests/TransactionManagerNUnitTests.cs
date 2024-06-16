
using AutoMapper;
using BenefitSeller.API.Contracts.RepositoryInterfaces;
using BenefitSeller.API.Managers;
using BenefitSeller.API.Models;
using BenefitSeller.API.Models.DomainModels;
using BenefitSeller.API.Models.ViewModels;
using Moq;
using NUnit.Framework;
using FluentAssertions;

namespace BenefitSellerNUnit.ManagerTests
{
    [TestFixture]
    public class TransactionManagerNUnitTests
    {
        [Test]
        public async Task GetAllByUserId_UserExists_ReturnsSuccessfulTransactions()
        {
            // Arrange
            var userId = 1;
            var user = new User { Id = userId };
            var transactions = new List<Transaction>
        {
            new Transaction { Id = 1, UserId = userId, TransactionStatus = StatusOfTransaction.Success },
            new Transaction { Id = 1, UserId = userId, TransactionStatus = StatusOfTransaction.Success }
        };
            var resTransactions = new List<TransactionViewModel>
        {
            new TransactionViewModel { Id = 1, UserId = userId },
            new TransactionViewModel { Id = 1, UserId = userId }
        };

            var userRepositoryMock = new Mock<IUserRepository>();
            userRepositoryMock.Setup(repo => repo.GetByIdAsync(userId))
                              .ReturnsAsync(user);

            var transactionRepositoryMock = new Mock<ITransactionsRepository>();
            transactionRepositoryMock.Setup(repo => repo.GetByUserIdAsync(userId, StatusOfTransaction.Success, 1, 100))
                                      .ReturnsAsync(transactions);

            var mapperMock = new Mock<IMapper>();
            mapperMock.Setup(mapper => mapper.Map<List<TransactionViewModel>>(transactions))
                      .Returns(resTransactions);

            var transactionManager = new TransactionsManager(transactionRepositoryMock.Object, userRepositoryMock.Object, mapperMock.Object,
                new Mock<IMerchantRepository>().Object, new Mock<ICompanyRepository>().Object, new Mock<IMerchantCategoryGroupRepository>().Object);

            // Act
            var result = await transactionManager.GetAllByUserId(userId);

            // Assert
            result.IsSuccess.Should().Be(true);
            result.ResponseMessage.Should().StartWith("Successful").And
                .EndWith("transactions").And.Contain("ful").And.HaveLength(23);
        }

        [Test]
        public async Task GetAllByUserId_UserExists_ReturnsFailedTransactions()
        {
            // Arrange
            var userId = 1;
            var user = new User { Id = userId };
            var transactions = new List<Transaction>
        {
            new Transaction { Id = 1, UserId = userId, TransactionStatus = StatusOfTransaction.Failed },
            new Transaction { Id = 2, UserId = userId, TransactionStatus = StatusOfTransaction.Failed }
        };
            var resTransactions = new List<TransactionViewModel>
        {
            new TransactionViewModel { Id = 1, UserId = userId },
            new TransactionViewModel { Id = 2, UserId = userId }
        };

            var userRepositoryMock = new Mock<IUserRepository>();
            userRepositoryMock.Setup(repo => repo.GetByIdAsync(userId))
                              .ReturnsAsync(user);

            var transactionRepositoryMock = new Mock<ITransactionsRepository>();
            transactionRepositoryMock.Setup(repo => repo.GetByUserIdAsync(userId, StatusOfTransaction.Failed, 1, 100))
                                      .ReturnsAsync(transactions);

            var mapperMock = new Mock<IMapper>();
            mapperMock.Setup(mapper => mapper.Map<List<TransactionViewModel>>(transactions))
                .Returns(resTransactions);

            var transactionManager = new TransactionsManager(transactionRepositoryMock.Object, userRepositoryMock.Object, mapperMock.Object,
                new Mock<IMerchantRepository>().Object, new Mock<ICompanyRepository>().Object, new Mock<IMerchantCategoryGroupRepository>().Object);

            bool filterFailed = true;

            // Act
            var result = await transactionManager.GetAllByUserId(userId, filterFailed);

            // Assert
            result.IsSuccess.Should().BeTrue();
            result.ResponseMessage.Should().StartWith("Failed").And.EndWith("transactions").And.HaveLength(19);
        }


        [Test]
        public async Task GetAllByUserId_UserDoesNotExist_ReturnsUserNotFoundError()
        {
            // Arrange
            var userId = 1;

            var userRepositoryMock = new Mock<IUserRepository>();
            userRepositoryMock.Setup(repo => repo.GetByIdAsync(userId))
                              .ReturnsAsync((User)null);

            var mapperMock = new Mock<IMapper>();

            var transactionManager = new TransactionsManager(new Mock<ITransactionsRepository>().Object, userRepositoryMock.Object,
                mapperMock.Object, new Mock<IMerchantRepository>().Object, new Mock<ICompanyRepository>().Object,
                new Mock<IMerchantCategoryGroupRepository>().Object);

            // Act
            var result = await transactionManager.GetAllByUserId(userId);

            // Assert
            result.IsSuccess.Should().BeFalse();
            result.ResponseMessage.Should().BeEquivalentTo("User doesn't exist");
        }
        [Test]
        public async Task CreateAsync_UserDoesNotExist_ReturnsUserNotFoundError()
        {
            // Arrange
            var userId = 1;
            var merchantId = 1;
            Merchant merchant = new Merchant { Id = merchantId, Name = "MerchantMock" };
            var transactionViewModel = new TransactionViewModel { UserId = userId, MerchantId = merchantId };

            var userRepositoryMock = new Mock<IUserRepository>();
            userRepositoryMock.Setup(repo => repo.GetByIdAsync(userId))
                              .ReturnsAsync((User)null);

            var merchantRepositoryMock = new Mock<IMerchantRepository>();
            merchantRepositoryMock.Setup(repo => repo.GetByIdAsync(merchantId))
                                      .ReturnsAsync(merchant);

            var mapperMock = new Mock<IMapper>();

            var transactionManager = new TransactionsManager(new Mock<ITransactionsRepository>().Object,
                new Mock<IUserRepository>().Object, mapperMock.Object, merchantRepositoryMock.Object,
                new Mock<ICompanyRepository>().Object, new Mock<IMerchantCategoryGroupRepository>().Object);

            // Act
            var result = await transactionManager.CreateAsync(transactionViewModel);

            // Assert
            result.IsSuccess.Should().BeFalse();
            result.ResponseMessage.Should().BeEquivalentTo("User doesn't exist");
        }

        [Test]
        public async Task CreateAsync_MerchantDoesNotExist_ReturnsUserNotFoundError()
        {
            // Arrange
            var userId = 1;
            var merchantId = 1;
            User user = new User { Id = merchantId, UserName = "MerchantMock" };
            var transactionViewModel = new TransactionViewModel { UserId = userId, MerchantId = merchantId };

            var userRepositoryMock = new Mock<IUserRepository>();
            userRepositoryMock.Setup(repo => repo.GetByIdAsync(userId))
                              .ReturnsAsync(user);

            var merchantRepositoryMock = new Mock<IMerchantRepository>();
            merchantRepositoryMock.Setup(repo => repo.GetByIdAsync(merchantId))
                                      .ReturnsAsync((Merchant)null);

            var mapperMock = new Mock<IMapper>();

            var transactionManager = new TransactionsManager(new Mock<ITransactionsRepository>().Object,
                userRepositoryMock.Object, mapperMock.Object, merchantRepositoryMock.Object,
                new Mock<ICompanyRepository>().Object, new Mock<IMerchantCategoryGroupRepository>().Object);

            // Act
            var result = await transactionManager.CreateAsync(transactionViewModel);

            // Assert
            result.IsSuccess.Should().BeFalse();
            result.ResponseMessage.Should().BeEquivalentTo("Merchant doesn't exist");
        }

        [Test]
        public async Task CreateAsync_UserAndMerchantExist_CreatesTransactionSuccessfully()
        {
            // Arrange
            var subscriptionPlanId = 1;
            var subscriptionPlan = new SubscriptionPlan { Id = subscriptionPlanId, Name = "NameTest", SubscriptionType = SubscriptionType.Standard };

            var companyId = 1;
            var company = new Company { Id = companyId };

            var userId = 1;
            var user = new User { Id = userId, SubscriptionPlanId = subscriptionPlanId, SubscriptionPlan = subscriptionPlan, CompanyId = companyId, Company = company };

            var merchantCategoryGroupId = 1;
            var merchantCategoryGroup = new MerchantCategoryGroup { Id = merchantCategoryGroupId, Name = "TestName" };

            var merchantCategoryId = 1;
            var merchantCategory = new MerchantCategory { Id = merchantCategoryId, MerchantCategoryGroupId = merchantCategoryGroupId };

            //Add the desired MerchantCategoryGroup to the company
            company.MerchantCategoryGroups = new List<MerchantCategoryGroup> { merchantCategoryGroup };

            var merchantId = 1;
            var merchant = new Merchant { Id = merchantId, MerchantCategoryId = merchantCategoryId, MerchantCategory = merchantCategory };

            var transactionViewModel = new TransactionViewModel { UserId = userId, MerchantId = merchantId };

            var resultTransaction = new Transaction();

            var userRepositoryMock = new Mock<IUserRepository>();
            userRepositoryMock.Setup(repo => repo.GetByIdAsync(userId))
                              .ReturnsAsync(user);

            var merchantRepositoryMock = new Mock<IMerchantRepository>();
            merchantRepositoryMock.Setup(repo => repo.GetByIdAsync(merchantId))
                                  .ReturnsAsync(merchant);

            var companyRepositoryMock = new Mock<ICompanyRepository>();
            companyRepositoryMock.Setup(repo => repo.GetByIdAsync(companyId))
                                 .ReturnsAsync(company);

            var merchantCategoryGroupRepositoryMock = new Mock<IMerchantCategoryGroupRepository>();
            merchantCategoryGroupRepositoryMock.Setup(repo => repo.GetByIdAsync(merchantCategoryGroupId))
                                              .ReturnsAsync(merchantCategoryGroup);

            var mapperMock = new Mock<IMapper>();
            mapperMock.Setup(mapper => mapper.Map<Transaction>(transactionViewModel))
                      .Returns(resultTransaction);

            var transactionRepositoryMock = new Mock<ITransactionsRepository>();
            transactionRepositoryMock.Setup(repo => repo.CreateAsync(resultTransaction));

            var transactionManager = new TransactionsManager(transactionRepositoryMock.Object,
                                                              userRepositoryMock.Object,
                                                              mapperMock.Object,
                                                              merchantRepositoryMock.Object,
                                                              companyRepositoryMock.Object,
                                                              merchantCategoryGroupRepositoryMock.Object);

            // Act
            var result = await transactionManager.CreateAsync(transactionViewModel);

            // Assert
            result.IsSuccess.Should().BeTrue();
            result.ResponseMessage.Should().BeEquivalentTo("Transaction successfuly created");
        }

        [Test]
        public async Task CreateAsync_User_Subscription_Invalid()
        {
            // Arrange
            var subscriptionPlanId = 1;
            var subscriptionPlan = new SubscriptionPlan { Id = subscriptionPlanId, Name = "NameTest", SubscriptionType = SubscriptionType.Standard };

            var companyId = 1;
            var company = new Company { Id = companyId };

            var userId = 1;
            var user = new User { Id = userId, SubscriptionPlanId = subscriptionPlanId, SubscriptionPlan = subscriptionPlan, CompanyId = companyId, Company = company };

            var merchantCategoryGroupId = 1;
            var merchantCategoryGroup = new MerchantCategoryGroup { Id = merchantCategoryGroupId, Name = "MerchantHasThisGroup" };

            var merchantCategoryGroupId2 = 1;
            var merchantCategoryGroup2 = new MerchantCategoryGroup { Id = merchantCategoryGroupId2, Name = "UserHasThisGroup" };

            var merchantCategoryId = 1;
            var merchantCategory = new MerchantCategory { Id = merchantCategoryId, MerchantCategoryGroupId = merchantCategoryGroupId };

            //Add the desired MerchantCategoryGroup to the company
            company.MerchantCategoryGroups = new List<MerchantCategoryGroup> { merchantCategoryGroup2 };

            var merchantId = 1;
            var merchant = new Merchant { Id = merchantId, MerchantCategoryId = merchantCategoryId, MerchantCategory = merchantCategory };

            var transactionViewModel = new TransactionViewModel { UserId = userId, MerchantId = merchantId };

            var resultTransaction = new Transaction();

            var userRepositoryMock = new Mock<IUserRepository>();
            userRepositoryMock.Setup(repo => repo.GetByIdAsync(userId))
                              .ReturnsAsync(user);

            var merchantRepositoryMock = new Mock<IMerchantRepository>();
            merchantRepositoryMock.Setup(repo => repo.GetByIdAsync(merchantId))
                                  .ReturnsAsync(merchant);

            var companyRepositoryMock = new Mock<ICompanyRepository>();
            companyRepositoryMock.Setup(repo => repo.GetByIdAsync(companyId))
                                 .ReturnsAsync(company);

            var merchantCategoryGroupRepositoryMock = new Mock<IMerchantCategoryGroupRepository>();
            merchantCategoryGroupRepositoryMock.Setup(repo => repo.GetByIdAsync(merchantCategoryGroupId))
                                              .ReturnsAsync(merchantCategoryGroup);

            var mapperMock = new Mock<IMapper>();
            mapperMock.Setup(mapper => mapper.Map<Transaction>(transactionViewModel))
                      .Returns(resultTransaction);

            var transactionRepositoryMock = new Mock<ITransactionsRepository>();
            transactionRepositoryMock.Setup(repo => repo.CreateAsync(resultTransaction));

            var transactionManager = new TransactionsManager(transactionRepositoryMock.Object,
                                                              userRepositoryMock.Object,
                                                              mapperMock.Object,
                                                              merchantRepositoryMock.Object,
                                                              companyRepositoryMock.Object,
                                                              merchantCategoryGroupRepositoryMock.Object);

            // Act
            var result = await transactionManager.CreateAsync(transactionViewModel);

            // Assert
            result.IsSuccess.Should().BeFalse();
            result.ResponseMessage.Should().Contain("User subscription doesn't include the");
        }
    }
}
