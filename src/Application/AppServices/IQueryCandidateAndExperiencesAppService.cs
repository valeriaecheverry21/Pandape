using Pandape.Application.CQRS.Queries;
using Pandape.Application.CQRS.Responses;
using System.Threading.Tasks;

namespace Pandape.Application.AppServices
{
    public interface IQueryCandidateAndExperiencesAppService
    {
        Task<GetDetailsCandidateAndExperiencesResponse> GetDetails(GetDetailsCandidateAndExperiencesQuery query);
    }
}
