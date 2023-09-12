using Pandape.Application.Dtos;

namespace Pandape.Application.CQRS.Responses
{
    public class GetByIdCandidateResponse
    {
        public CandidateDto CandidateDto { get; set; }

        public string Errors { get; internal set; }
    }
}