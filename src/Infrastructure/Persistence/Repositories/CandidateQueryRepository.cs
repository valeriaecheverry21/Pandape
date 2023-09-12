using Pandape.Domain.Entities;
using Pandape.Infrastructure.Persistence.DataBase;

namespace Pandape.Infrastructure.Persistence.Repositories
{
    public class CandidateQueryRepository : QueryRepository<Candidate>, ICandidateQueryRepository
    {
        public CandidateQueryRepository(PandapeContext context) : base(context)
        {
        }
    }
}
