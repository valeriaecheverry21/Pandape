using MediatR;
using Pandape.Application.CQRS.Responses;

namespace Pandape.Application.CQRS.Commands
{
    public class DeleteCandidateCommand : IRequest<DeleteCandidateResponse>
    {
        public int Id { get; set; }

        public DeleteCandidateCommand(int id)
        {
            Id = id;
        }
    }
}
