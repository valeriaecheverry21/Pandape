using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pandape.Domain.Entities;
using System;
using System.Reflection.Emit;

namespace Pandape.Infrastructure.Persistence.DataBase.Configuration
{
    public class CandidateExperienceConfiguration : IEntityTypeConfiguration<CandidateExperience>
    {
        public void Configure(EntityTypeBuilder<CandidateExperience> builder)
        {
            builder.HasOne(c => c.Candidate).WithMany(e => e.CandidateExperiences).HasForeignKey(e => e.CandidateId);
        }
    }
}