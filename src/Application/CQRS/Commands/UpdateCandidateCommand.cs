using MediatR;
using Pandape.Application.CQRS.Responses;
using Pandape.Domain.Entities;

namespace Pandape.Application.CQRS.Commands
{
    public class UpdateCandidateCommand : IRequest<UpdateCandidateResponse>
    {
        public int Id { get; set; }

        public Candidate Candidate { get; set; }


        public UpdateCandidateCommand(int id, Candidate candidate)
        {
            Id = id;

            Candidate = candidate;
        }
    }
}
