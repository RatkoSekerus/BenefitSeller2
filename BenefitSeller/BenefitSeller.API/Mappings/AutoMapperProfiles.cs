using AutoMapper;
using AutoMapper.Configuration.Annotations;
using BenefitSeller.API.Models.DomainModels;
using BenefitSeller.API.Models.ViewModels;

namespace BenefitSeller.API.Mappings
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<TransactionViewModel, Transaction>()
                .ForMember(dest => dest.Id, opt => opt.Ignore())
                .ReverseMap();
        }
    }
}
