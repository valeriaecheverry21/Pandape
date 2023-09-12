using Pandape.Domain.Entities;
using Pandape.Infrastructure.Persistence.DataBase;

namespace Pandape.Infrastructure.Persistence.Repositories
{
    public class CandidateCommandRepository : CommandRepository<Candidate>, ICandidateCommandRepository
    {
        public CandidateCommandRepository(PandapeContext context) : base(context)
        {
        }
    }
}
