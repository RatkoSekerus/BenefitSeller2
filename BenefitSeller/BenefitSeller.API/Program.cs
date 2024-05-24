using BenefitSeller.API.Contracts.ManagerInterfaces;
using BenefitSeller.API.Contracts.RepositoryInterfaces;
using BenefitSeller.API.Data;
using BenefitSeller.API.Managers;
using BenefitSeller.API.Mappings;
using BenefitSeller.API.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<BenefitSellerDbContext>(options => 
options.UseSqlServer(builder.Configuration.GetConnectionString("BenefitSellerConnectionString")));

builder.Services.AddScoped<ITransactionsManager, TransactionsManager>();
builder.Services.AddScoped<ITransactionsRepository, TransactionsRepository>();
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IMerchantRepository, MerchantRepository>();
builder.Services.AddScoped<ICompanyRepository, CompanyRepository>();
builder.Services.AddScoped<IMerchantCategoryGroupRepository, MerchantCategoryGroupRepository>();

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
