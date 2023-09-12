using AutoMapper;
using Microsoft.Extensions.Logging;
using Pandape.Application.CQRS.Queries;
using Pandape.Application.CQRS.Responses;
using Pandape.Application.Dtos;
using Pandape.Infrastructure.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Pandape.Application.AppServices
{
    public class QueryCandidateAndExperiencesAppService : AppServiceBase, IQueryCandidateAndExperiencesAppService
    {
        protected ICandidateQueryRepository CandidateQueryRepository { get; }

        protected ICandidateExperienceQueryRepository CandidateExperienceQueryRepository { get; }

        protected ILogger<QueryCandidateAndExperiencesAppService> Log { get; }

        public QueryCandidateAndExperiencesAppService(
            IMapper mapper,
            ILogger<QueryCandidateAndExperiencesAppService> logger,
            ICandidateQueryRepository candidateQueryRepository,
            ICandidateExperienceQueryRepository candidateExperienceQueryRepository) 
            : base(mapper)
        {
            Log = logger;

            CandidateQueryRepository = candidateQueryRepository;

            CandidateExperienceQueryRepository = candidateExperienceQueryRepository;      
        }

        public async Task<GetDetailsCandidateAndExperiencesResponse> GetDetails(GetDetailsCandidateAndExperiencesQuery query)
        {
            var response = new GetDetailsCandidateAndExperiencesResponse();

            try
            {
                var candidate = await CandidateQueryRepository.GetById(query.Id);

                var candidateExperiences = await CandidateExperienceQueryRepository.Find(e => e.CandidateId == candidate.Id);

                response.CandidateDto = Mapper.Map<CandidateDto>(candidate);

                response.CandidateExperienceDto = Mapper.Map<IEnumerable<CandidateExperienceDto>>(candidateExperiences);
            }
            catch (Exception ex)
            {
                Log.LogError($"{nameof(QueryCandidateAppService)} - {nameof(GetDetailsCandidateResponse)} Error: {ex.Message}");
            }

            return response;
        }
    }
}
