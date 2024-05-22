using AutoMapper;
using BenefitSeller.API.Models;
using BenefitSeller.API.ViewModels;

namespace BenefitSeller.API.Mappings
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<Transaction, TransactionViewModel>()
                .ReverseMap();
        }
    }
}
