using AutoMapper;
using Pandape.Application.Dtos;
using Pandape.Host.Mvc.ViewModels;

namespace Pandape.Host.Mvc.Mapping
{
    public class CandidateProfile : Profile
    {
        public CandidateProfile() 
        {
            CreateMap<CandidateDto, CandidateViewModel>().ReverseMap();

            CreateMap<CandidateExperienceDto, CandidateExperienceViewModel>().ReverseMap();
        }
    }
}