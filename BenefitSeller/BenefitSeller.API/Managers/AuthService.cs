using BenefitSeller.API.Contracts.ManagerInterfaces;
using BenefitSeller.API.Models.DomainModels;
using Dapper;
using Microsoft.IdentityModel.Tokens;
using Npgsql;
using System.Data;
using System.Data.Common;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace BenefitSeller.API.Managers
{
    public class AuthService : IAuthService
    {
        private IDbConnection _dbConnection;
        private readonly IConfiguration _configuration;

        public AuthService(IDbConnection dbConnection, IConfiguration configuration)
        {
            _dbConnection = dbConnection;
            _configuration = configuration;
        }

        public async Task RegisterUser(string username, string password)
        {
            // Generate the hash (BCrypt automatically generates the salt as part of the hash)
            var hash = BCrypt.Net.BCrypt.HashPassword(password);

            var query = "INSERT INTO AdminUsers (Username, PasswordHash, Role) VALUES (@Username, @PasswordHash, @Role)";
            await _dbConnection.ExecuteAsync(query, new { Username = username, PasswordHash = hash, Role = "admin" });
        }


        public async Task<AdminUser> ValidateUser(string username, string password)
        {
            var user = await _dbConnection.QuerySingleOrDefaultAsync<AdminUser>(
                "SELECT * FROM AdminUsers WHERE Username = @Username",
                new { Username = username }
            );

            // Ensure you're passing the hash string to BCrypt.Verify
            if (user == null || !BCrypt.Net.BCrypt.Verify(password, user.PasswordHash))
            {
                return null;  // Invalid username or password
            }

            return user;  // Valid user
        }


        public string GenerateJwtToken(string username, string role)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JwtSettings:Key"]));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var claims = new[]
            {
            new Claim(ClaimTypes.Role, role)
        };

            var token = new JwtSecurityToken(
                issuer: _configuration["JwtSettings:issuer"],
                audience: _configuration["JwtSettings:audience"],
                claims: claims,
                expires: DateTime.Now.AddHours(1),
                signingCredentials: credentials
            );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        public async Task<bool> UserExists(string username)
        {
            var user = await _dbConnection.QuerySingleOrDefaultAsync<AdminUser>(
                "SELECT * FROM AdminUsers WHERE Username = @Username",
                new { Username = username }
            );

            return user != null;
        }
    }
}
