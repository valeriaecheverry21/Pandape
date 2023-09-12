using Pandape.Application.Dtos;
using System.Collections.Generic;

namespace Pandape.Application.CQRS.Responses
{
    public class FindCandidateResponse
    {
        public IEnumerable<CandidateDto> CandidatesDto { get; set; }
    }
}