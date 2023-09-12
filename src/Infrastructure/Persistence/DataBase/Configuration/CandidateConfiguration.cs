using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pandape.Domain.Entities;
using System;
using System.Reflection.Metadata;

namespace Pandape.Infrastructure.Persistence.DataBase.Configuration
{
    public class CandidateConfiguration : IEntityTypeConfiguration<Candidate>
    {
        public void Configure(EntityTypeBuilder<Candidate> builder)
        {
            builder.HasMany(e => e.CandidateExperiences).WithOne(e => e.Candidate).OnDelete(DeleteBehavior.Cascade);
        }
    }
}
