using Microsoft.EntityFrameworkCore;
using Pandape.Domain.Entities;
using Pandape.Infrastructure.Persistence.DataBase.Configuration;

namespace Pandape.Infrastructure.Persistence.DataBase
{
    public class PandapeContext : DbContext
    {
        public PandapeContext(DbContextOptions<PandapeContext> options)
            : base(options)
        {
        }

        public DbSet<Candidate> Candidates { get; set; }

        public DbSet<CandidateExperience> CandidateExperiences { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new CandidateConfiguration());
            modelBuilder.ApplyConfiguration(new CandidateExperienceConfiguration());
        }
    }
}
