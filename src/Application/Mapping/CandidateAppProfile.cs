using AutoMapper;
using Pandape.Application.Dtos;
using Pandape.Domain.Entities;

namespace Pandape.Application.Mapping
{
    public class CandidateAppProfile : Profile
    {
        public CandidateAppProfile() 
        { 
            CreateMap<Candidate, CandidateDto>().ReverseMap();
            CreateMap<CandidateExperience, CandidateExperienceDto>().ReverseMap();
        }
    }
}
