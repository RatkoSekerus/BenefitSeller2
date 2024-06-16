using BenefitSeller.API.Contracts.RepositoryInterfaces;
using BenefitSeller.API.Models.DomainModels;
using Dapper;
using Dapper.FastCrud;
using Npgsql;
using System.Data;
using System.Data.Common;

namespace BenefitSeller.API.Repositories
{
    /// <summary>
    /// Represents a repository for performing operations on <see cref="MerchantCategoryGroup"/> entities.
    /// </summary>
    public class MerchantCategoryGroupRepositoryDapper : IMerchantCategoryGroupRepository
    {
        IDbConnection _dbConnection;

        /// <summary>
        /// Initializes a new instance of the <see cref="MerchantCategoryGroupRepository"/> class.
        /// </summary>
        /// <param name="dbContext"></param>
        public MerchantCategoryGroupRepositoryDapper(IDbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        /// <summary>
        /// Retrieves a Merchant Category Group entity by its unique identifier.
        /// </summary>
        /// <param name="id">The unique identifier of the Merchant Category Group.</param>
        /// <returns>
        /// A populated object of type <see cref="MerchantCategoryGroup"/>, or null if no entity with the specified id is found.
        /// </returns>
        public async Task<MerchantCategoryGroup?> GetByIdAsync(int id)
        {
            return await _dbConnection.GetAsync(new MerchantCategoryGroup { Id = id }); 
        }
    }
}
