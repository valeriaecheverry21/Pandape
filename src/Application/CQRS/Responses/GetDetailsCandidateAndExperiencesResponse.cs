using Pandape.Application.Dtos;
using System.Collections.Generic;

namespace Pandape.Application.CQRS.Responses
{
    public class GetDetailsCandidateAndExperiencesResponse
    {
        public CandidateDto CandidateDto { get; set; }

        public IEnumerable<CandidateExperienceDto> CandidateExperienceDto { get; set; }
    }
}
