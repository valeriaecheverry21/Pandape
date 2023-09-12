using MediatR;
using Pandape.Application.CQRS.Responses;

namespace Pandape.Application.CQRS.Queries
{
    public class GetDetailsCandidateAndExperiencesQuery : IRequest<GetDetailsCandidateAndExperiencesResponse>
    {
        public int Id { get; }

        public GetDetailsCandidateAndExperiencesQuery(int id)
        {
            Id = id;
        }
    }
}
