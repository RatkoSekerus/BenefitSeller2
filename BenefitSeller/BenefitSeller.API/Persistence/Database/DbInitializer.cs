using DbUp;
using System.Reflection;

namespace BenefitSeller.API.Persistence.Database
{
    public class DbInitializer
    {
        public static void Initialize(string connectionString)
        {
            //ensure the postgres database does exists based on connection string
            EnsureDatabase.For.PostgresqlDatabase(connectionString);

            var upgrader = DeployChanges.To
                .PostgresqlDatabase(connectionString)
                .WithScriptsEmbeddedInAssembly(Assembly.GetExecutingAssembly())  //get hold of all sql scripts
                .WithTransaction()       
                .LogToConsole()
                .Build();

            //run script by order
            var result = upgrader.PerformUpgrade();

            if (!result.Successful)
            {
                throw new InvalidOperationException("failed upgrade of database");
            }
        }
    }
}
