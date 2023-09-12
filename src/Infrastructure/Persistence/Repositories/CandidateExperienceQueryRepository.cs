using Pandape.Domain.Entities;
using Pandape.Infrastructure.Persistence.DataBase;

namespace Pandape.Infrastructure.Persistence.Repositories
{
    public class CandidateExperienceQueryRepository : QueryRepository<CandidateExperience>, ICandidateExperienceQueryRepository
    {
        public CandidateExperienceQueryRepository(PandapeContext context) : base(context)
        {
        }
    }
}