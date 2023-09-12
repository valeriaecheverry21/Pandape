using Pandape.Domain.Entities;
using Pandape.Infrastructure.Persistence.DataBase;

namespace Pandape.Infrastructure.Persistence.Repositories
{
    public class CandidateExperienceCommandRepository : CommandRepository<CandidateExperience>, ICandidateExperienceCommandRepository
    {
        public CandidateExperienceCommandRepository(PandapeContext context) : base(context)
        {
        }
    }
}
