using BenefitSeller.API.Contracts.RepositoryInterfaces;
using BenefitSeller.API.Models.DomainModels;
using Dapper;
using Dapper.FastCrud;

using Npgsql;
using System;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Net;

namespace BenefitSeller.API.Repositories
{
    /// <summary>
    /// Represents a repository for performing operations on <see cref="User"/> entities.
    /// </summary>
    public class UserRepositoryDapper : IUserRepository
    {
        private IDbConnection _dbConnection;

        public UserRepositoryDapper(IDbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        /// <summary>
        /// Retrieves a user by its unique identifier asynchronously.
        /// </summary>
        /// <param name="id">The unique identifier of the user.</param>
        /// <returns>A populated object of type <see cref="User"/></returns>
        public async Task<User?> GetByIdAsync(int id)
        {
            User? user = await _dbConnection.GetAsync(new User { Id = id });

            if (user == null)
            {
                return null;
            }

            user.Company = await _dbConnection.GetAsync(new Company { Id = user.CompanyId });
            user.SubscriptionPlan = await _dbConnection.GetAsync(new SubscriptionPlan { Id = user.SubscriptionPlanId });

            return user;
        }

        /// <summary>
        /// Updates an existing user asynchronously.
        /// </summary>
        /// <returns>A task representing the asynchronous operation.</returns>
        public async Task UpdateAsync(User updatedUser)
        {
            User? currentUser = await _dbConnection.GetAsync(new User { Id = updatedUser.Id });

            if (currentUser != null)
            {
                _dbConnection.Update(currentUser);
            }
        }
    }
}
