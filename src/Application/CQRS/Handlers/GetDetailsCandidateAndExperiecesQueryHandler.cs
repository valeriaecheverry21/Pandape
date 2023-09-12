using Pandape.Application.AppServices;
using Pandape.Application.CQRS.Queries;
using Pandape.Application.CQRS.Responses;
using System.Threading;
using System.Threading.Tasks;

namespace Pandape.Application.CQRS.Handlers
{
    public class GetDetailsCandidateAndExperiecesQueryHandler 
        : QueryHandlerBase< GetDetailsCandidateAndExperiencesQuery, 
          GetDetailsCandidateAndExperiencesResponse >
    {
        protected IQueryCandidateAndExperiencesAppService QueryCandidateAndExperiencesAppService { get; }

        public GetDetailsCandidateAndExperiecesQueryHandler(IQueryCandidateAndExperiencesAppService queryCandidateExperiencesAppService) =>
            QueryCandidateAndExperiencesAppService = queryCandidateExperiencesAppService;

        public override Task<GetDetailsCandidateAndExperiencesResponse> Handle(GetDetailsCandidateAndExperiencesQuery request, CancellationToken cancellationToken) =>
            QueryCandidateAndExperiencesAppService.GetDetails(request);
    }
}
