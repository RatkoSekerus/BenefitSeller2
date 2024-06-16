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
    /// Represents a repository for performing operations on <see cref="Merchant"/> entities.
    /// </summary>
    public class MerchantRepositoryDapper : IMerchantRepository
    {
        IDbConnection _dbConnection;

        /// <summary>
        /// Initializes a new instance of the <see cref="MerchantRepository"/> class.
        /// </summary>
        /// <param name="dbContext"></param>
        public MerchantRepositoryDapper(IDbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        /// <summary>
        /// Retrieves a Merchant entity by its unique identifier.
        /// </summary>
        /// <param name="id">The unique identifier of the Merchant.</param>
        /// <returns>
        /// A populated object of type <see cref="Merchant"/>, or null if no Merchant with the specified id is found.
        /// </returns>
        public async Task<Merchant?> GetByIdAsync(int id)
        {
            Merchant? merchant = await _dbConnection.GetAsync(new Merchant { Id = id });

            if (merchant == null)
            {
                return null;
            }

            merchant.MerchantCategory = await _dbConnection.GetAsync(new MerchantCategory { Id = merchant.MerchantCategoryId });

            return merchant;
        }

        /// <summary>
        /// Updates an existing Merchant entity.
        /// </summary>
        /// <param name="merchant">The Merchant model containing updated information.</param>
        /// <returns>A task representing the asynchronous operation.</returns>
        public async Task UpdateAsync(Merchant updatedMerchant)
        {
            Merchant? currentMerchant = await _dbConnection.GetAsync(new Merchant { Id = updatedMerchant.Id });

            if (currentMerchant != null)
            {
                await _dbConnection.UpdateAsync(updatedMerchant);
            }
        }
    }
}
