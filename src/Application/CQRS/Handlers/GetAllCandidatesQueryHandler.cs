using Pandape.Application.AppServices;
using Pandape.Application.CQRS.Queries;
using Pandape.Application.CQRS.Responses;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Pandape.Application.CQRS.Handlers
{
    public class GetAllCandidatesQueryHandler : QueryHandlerBase<GetAllCandidatesQuery, GetAllCandidatesResponse>
    {
        protected IQueryCandidateAppService QueryCandidateAppService { get; }

        public GetAllCandidatesQueryHandler(IQueryCandidateAppService queryCandidateAppService) =>
            QueryCandidateAppService = queryCandidateAppService;

        public override Task<GetAllCandidatesResponse> Handle(GetAllCandidatesQuery query, CancellationToken cancellationToken) =>
            QueryCandidateAppService.GetAll();
    }
}
