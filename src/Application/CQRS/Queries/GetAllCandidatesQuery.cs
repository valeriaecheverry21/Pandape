using MediatR;
using Pandape.Application.CQRS.Responses;

namespace Pandape.Application.CQRS.Queries
{
    public class GetAllCandidatesQuery : IRequest<GetAllCandidatesResponse>
    {
    }
}
