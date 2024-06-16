namespace BenefitSeller.API.Repositories.DbConnectionWrappers
{
    public interface IDbConnectionWrapper
    {
        Task<List<T>> QueryAsync<T>(string sql, object param = null);

        Task ExecuteAsync(string sql, object param = null);

        Task<List<T>> FindAsync<T>();
    }
}
