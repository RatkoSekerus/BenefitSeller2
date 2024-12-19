using BenefitSeller.API.Contracts.ManagerInterfaces;
using BenefitSeller.API.Contracts.RepositoryInterfaces;
using BenefitSeller.API.Managers;
using BenefitSeller.API.Mappings;
using BenefitSeller.API.Persistence.Database;
using BenefitSeller.API.Repositories;
using BenefitSeller.API.Repositories.DbConnectionWrappers;
using Dapper.FastCrud;
using Npgsql;
using System.Collections;
using System.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddScoped<ITransactionsManager, TransactionsManager>();
builder.Services.AddScoped<ITransactionsRepository, TransactionsRepositoryDapper>();
builder.Services.AddScoped<IUserRepository, UserRepositoryDapper>();
builder.Services.AddScoped<IMerchantRepository, MerchantRepositoryDapper>();
builder.Services.AddScoped<ICompanyRepository, CompanyRepositoryDapper>();
builder.Services.AddScoped<IMerchantCategoryGroupRepository, MerchantCategoryGroupRepositoryDapper>();
builder.Services.AddScoped<IDbConnectionWrapper, DbConnectionWrapper>();

var dbHost = Environment.GetEnvironmentVariable("POSTGRES_HOST");
var dbName = Environment.GetEnvironmentVariable("POSTGRES_DB");
var dbUser = Environment.GetEnvironmentVariable("POSTGRES_USER");
var dbPassword = Environment.GetEnvironmentVariable("POSTGRES_PASSWORD");

builder.Services.AddScoped<IDbConnection>(sp =>
{
    string? connectionString;

    if (OperatingSystem.IsWindows())
    {
        // Retrieve connection string from configuration
        connectionString = builder.Configuration.GetConnectionString("BenefitSellerConnectionStringPostgres");
    }
    else
    {
        connectionString = Environment.GetEnvironmentVariable("Database__ConnectionStrings__DefaultConnection");
    }

    if (string.IsNullOrEmpty(connectionString))
    {
        throw new InvalidOperationException("Connection string is not configured correctly.");
    }

    return new NpgsqlConnection(connectionString);
});


OrmConfiguration.DefaultDialect = SqlDialect.PostgreSql;

builder.Services.AddAutoMapper(typeof(AutoMapperProfiles));

var app = builder.Build();

{
    if (OperatingSystem.IsWindows())
    {
        // Retrieve connection string from configuration
        DbInitializer.Initialize(builder.Configuration.GetConnectionString("BenefitSellerConnectionStringPostgres"));
    } else
    {
        DbInitializer.Initialize(app.Configuration["Database:ConnectionStrings:DefaultConnection"]);

    }
}

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
