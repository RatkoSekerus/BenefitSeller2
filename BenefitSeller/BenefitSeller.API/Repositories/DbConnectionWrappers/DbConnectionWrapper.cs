
using Dapper;
using Dapper.FastCrud;
using Npgsql;
using System.Data;

namespace BenefitSeller.API.Repositories.DbConnectionWrappers
{
    public class DbConnectionWrapper : IDbConnectionWrapper
    {
        private readonly IDbConnection _dbConnection;

        public DbConnectionWrapper(IDbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public async Task<List<T>> QueryAsync<T>(string sql, object param = null)
        {
            return (await _dbConnection.QueryAsync<T>(sql, param)).ToList();
        }

        public async Task ExecuteAsync(string sql, object param = null)
        {
            await _dbConnection.ExecuteAsync(sql, param);
        }

        public async Task<List<T>> FindAsync<T>()
        {
            return (await _dbConnection.FindAsync<T>()).ToList();
        }

    }

}
