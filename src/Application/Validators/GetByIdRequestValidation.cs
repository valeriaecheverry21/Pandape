using Pandape.Application.CQRS.Queries;
using Pandape.Infrastructure.Persistence.Repositories;
using System;
using System.Linq;

namespace Pandape.Application.Validators
{
    public class GetByIdRequestValidation : IRequestValidation<GetByIdCandidateQuery>
    {
        public ICandidateQueryRepository CandidateQueryRepository { get; }

        public GetByIdCandidateQuery Query { get; }

        public bool IRequestValid { get; set; }

        public GetByIdRequestValidation(ICandidateQueryRepository candidateQueryRepository, GetByIdCandidateQuery query)
        {
            CandidateQueryRepository = candidateQueryRepository;
            Query = query;
            IRequestValid = ValidateRequest(query);
        }

        private bool ValidateRequest(GetByIdCandidateQuery query)
        {
            var result = CandidateQueryRepository.Find(c => c.Id == query.Id).Result.Count();

            return result > 0;
        }

        bool IRequestValidation<GetByIdCandidateQuery>.ValidateRequest(GetByIdCandidateQuery request)
        {
            throw new NotImplementedException();
        }
    }
}
