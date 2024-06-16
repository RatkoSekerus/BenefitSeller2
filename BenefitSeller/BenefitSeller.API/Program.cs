using BenefitSeller.API.Contracts.ManagerInterfaces;
using BenefitSeller.API.Contracts.RepositoryInterfaces;
using BenefitSeller.API.Managers;
using BenefitSeller.API.Mappings;
using BenefitSeller.API.Repositories;
using BenefitSeller.API.Repositories.DbConnectionWrappers;
using Dapper.FastCrud;
using Microsoft.Extensions.Configuration;
using Npgsql;
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
builder.Services.AddScoped<IDbConnection>(sp =>
{
    var connectionString = builder.Configuration.GetConnectionString("BenefitSellerConnectionStringPostgres");
    return new NpgsqlConnection(connectionString);
});

OrmConfiguration.DefaultDialect = SqlDialect.PostgreSql;

builder.Services.AddAutoMapper(typeof(AutoMapperProfiles));

var app = builder.Build();

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
