using Pandape.Application.Dtos;
using System.Collections.Generic;

namespace Pandape.Application.CQRS.Responses
{
    public class GetAllCandidatesResponse
    {
        public IEnumerable<CandidateDto> CandidatesDto { get; set; }

        public string Errors { get;  set; }

        public List<CandidateExperienceDto> CandidateExperiencesDto { get; set; }
    }
}