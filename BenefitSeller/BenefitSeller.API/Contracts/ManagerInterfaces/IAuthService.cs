using BenefitSeller.API.Models.DomainModels;

namespace BenefitSeller.API.Contracts.ManagerInterfaces
{
    public interface IAuthService
    {
        Task RegisterUser(string username, string password);
        Task<AdminUser> ValidateUser(string username, string password);
        string GenerateJwtToken(string username, string role);
        Task<bool> UserExists(string username);
    }
}
