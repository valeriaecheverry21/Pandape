using Pandape.Application.CQRS.Queries;
using Pandape.Application.CQRS.Responses;
using System.Threading.Tasks;

namespace Pandape.Application.AppServices
{
    public interface IQueryCandidateAppService
    {
        Task<FindCandidateResponse> Find(FindCandidateQuery query);

        Task<GetAllCandidatesResponse> GetAll();

        Task<GetByIdCandidateResponse> GetById(GetByIdCandidateQuery query);

        Task<GetDetailsCandidateResponse> GetDetails(GetDetailsCandidateQuery query);
    }
}
