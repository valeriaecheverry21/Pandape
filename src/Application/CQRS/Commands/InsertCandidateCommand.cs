using MediatR;
using Pandape.Application.CQRS.Responses;
using Pandape.Domain.Entities;

namespace Pandape.Application.CQRS.Commands
{
    public class InsertCandidateCommand : IRequest<InsertCandidateResponse>
    {
        public Candidate Candidate { get; set; }


        public InsertCandidateCommand(Candidate candidate)
        {
            Candidate = candidate;
        }
    }
}
