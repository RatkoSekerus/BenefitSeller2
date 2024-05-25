using AutoMapper;
using BenefitSeller.API.Models.DomainModels;
using BenefitSeller.API.Models.ViewModels;

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
