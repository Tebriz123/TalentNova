using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalentNova.Domain.Entities;

namespace TalentNova.Persistence.Cofigurations
{
    public class EducationConfiguration : IEntityTypeConfiguration<Education>
    {
        public void Configure(EntityTypeBuilder<Education> builder)
        {
            builder.ToTable("Educations");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.UniversitateName)
                .IsRequired()
                .HasMaxLength(200);

            builder.Property(x => x.Degree)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(x => x.FieldOfStudy)
                .HasMaxLength(150);

            builder.HasOne<Candidate>()
                .WithMany()
                .HasForeignKey(x => x.CandidateId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
