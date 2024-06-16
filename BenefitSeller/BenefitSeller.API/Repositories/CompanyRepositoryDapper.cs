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
    /// Represents a repository for performing operations on <see cref="Company"/> entities.
    /// </summary>
    public class CompanyRepositoryDapper : ICompanyRepository
    {
        private IDbConnection _dbConnection;

        /// <summary>
        /// Initializes a new instance of the <see cref="CompanyRepository"/> class.
        /// </summary>
        /// <param name="configuration"></param>
        public CompanyRepositoryDapper(IDbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        /// <summary>
        /// Retrieves a Company entity by its unique identifier.
        /// </summary>
        /// <param name="id">The unique identifier of the Company.</param>
        /// <returns>
        /// A populated object of type <see cref="Company"/>, or null if no Company with the specified id is found.
        /// </returns>
        public async Task<Company?> GetByIdAsync(int id)
        {
            Company? company = await _dbConnection.GetAsync(new Company { Id = id });

            if (company == null)
            {
                return null;
            }

            var getCompanyBenefits = @"SELECT ""merchantcategorygroupid"" FROM ""companybenefit"" WHERE ""companyid"" = @companyid";
            var companyBenefits = await _dbConnection.QueryAsync<int>(getCompanyBenefits, new { companyid = id });

            if (companyBenefits.Any())
            {
                var getMerchantCategoryGroupsQuery = @"SELECT * FROM ""merchantcategorygroup"" WHERE ""id"" = ANY(@benefitIds)";
                IEnumerable<MerchantCategoryGroup> merchantCategoryGroups =
                    await _dbConnection.QueryAsync<MerchantCategoryGroup>(getMerchantCategoryGroupsQuery, new { benefitIds = companyBenefits });

                company.MerchantCategoryGroups = merchantCategoryGroups.ToList();
            }

            return company;
        }
    }
}
