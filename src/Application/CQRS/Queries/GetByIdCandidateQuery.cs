using MediatR;
using Pandape.Application.CQRS.Responses;

namespace Pandape.Application.CQRS.Queries
{
    public class GetByIdCandidateQuery : IRequest<GetByIdCandidateResponse>
    {
        public int Id { get; set; }

        public GetByIdCandidateQuery(int id)
        {
            Id = id;
        }
    }
}
