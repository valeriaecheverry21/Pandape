using MediatR;
using Pandape.Application.CQRS.Responses;

namespace Pandape.Application.CQRS.Queries
{
    public class GetDetailsCandidateQuery : IRequest<GetDetailsCandidateResponse>
    {
        public int Id { get; }

        public GetDetailsCandidateQuery(int id)
        {
            Id = id;
        }
    }
}
