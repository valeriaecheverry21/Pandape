using Pandape.Application.AppServices;
using Pandape.Application.CQRS.Queries;
using Pandape.Application.CQRS.Responses;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Pandape.Application.CQRS.Handlers
{
    public class GetByIdCandidateQueryHandler : QueryHandlerBase<GetByIdCandidateQuery, GetByIdCandidateResponse>
    {
        protected IQueryCandidateAppService QueryCandidateAppService { get; }

        public GetByIdCandidateQueryHandler( IQueryCandidateAppService queryCandidateAppService) =>
            QueryCandidateAppService = queryCandidateAppService;

        public override Task<GetByIdCandidateResponse> Handle(GetByIdCandidateQuery query, CancellationToken cancellationToken) =>
            QueryCandidateAppService.GetById(query);
    }
}
