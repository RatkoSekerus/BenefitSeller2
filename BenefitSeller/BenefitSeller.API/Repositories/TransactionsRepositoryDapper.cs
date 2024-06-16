using BenefitSeller.API.Contracts.RepositoryInterfaces;
using BenefitSeller.API.Models;
using BenefitSeller.API.Models.DomainModels;
using BenefitSeller.API.Repositories.DbConnectionWrappers;
using Dapper;
using Dapper.FastCrud;
using Microsoft.Extensions.Configuration;
using Npgsql;
using System.Data;
using Transaction = BenefitSeller.API.Models.DomainModels.Transaction;


namespace BenefitSeller.API.Repositories
{
    /// <summary>
    /// Represents a repository for performing operations on <see cref="Transaction"/> entities.
    /// </summary>
    public class TransactionsRepositoryDapper : ITransactionsRepository
    {
        private readonly IDbConnectionWrapper _dbConnectionWrapper;

        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionsRepository"/> class.
        /// </summary>
        /// <param name="dbContext"></param>
        public TransactionsRepositoryDapper(IDbConnectionWrapper dbConnectionWrapper)
        {
            _dbConnectionWrapper = dbConnectionWrapper;
        }


        /// <summary>
        /// Creates a new transaction asynchronously.
        /// </summary>
        /// <param name="transaction">The transaction to create.</param>
        /// <returns>A populated object of type <see cref="Transaction"/></returns>
        public async Task CreateAsync(Transaction transaction)
        {
            transaction.TransactionDate = DateTime.UtcNow;
            var createQuery = @"Insert into ""transactions"" (""amount"",""transactiondate"",""transactionstatus"",""userid"",""merchantid"")
                                    values(@amount,@transactiondate,@transactionstatus,@userid,@merchantid)";
            await _dbConnectionWrapper.ExecuteAsync(createQuery,
                new {@amount = transaction.Amount, @transactiondate = transaction.TransactionDate, @transactionstatus = transaction.TransactionStatus,
                     @userid = transaction.UserId, @merchantid = transaction.MerchantId});
        }

        /// <summary>
        /// Retrieves all transactions asynchronously.
        /// </summary>
        /// <returns>A populated list of <see cref="Transaction"/> objects.</returns>
        public async Task<List<Transaction>> GetAllAsync()
        {
            return (await _dbConnectionWrapper.FindAsync<Transaction>());
        }

        /// <summary>
        /// Retrieves transactions associated with a specific user asynchronously.
        /// </summary>
        /// <param name="id">The unique identifier of the user.</param>
        /// <param name="status">The status of the transactions to retrieve.</param>
        /// <param name="pageNumber">The page number if pagination is needed (default is 1).</param>
        /// <param name="pageSize">The page size if pagination is needed (default is 100).</param>
        /// <returns> A populated list of objects of type <see cref="Transaction"/></returns>
        public async Task<List<Transaction>> GetByUserIdAsync(int userId, StatusOfTransaction status, int pageNumber = 1, int pageSize = 100)
        {
            int skip = (pageNumber - 1) * pageSize;

            string query = @"
                SELECT *
                FROM ""transactions""
                WHERE ""userid"" = @UserId AND ""transactionstatus"" = @Status
                ORDER BY ""transactiondate"" DESC
                OFFSET @Skip LIMIT @PageSize";

            return (await _dbConnectionWrapper.QueryAsync<Transaction>(query, new { UserId = userId, Status = status, Skip = skip, PageSize = pageSize }));
        }
    }
}
