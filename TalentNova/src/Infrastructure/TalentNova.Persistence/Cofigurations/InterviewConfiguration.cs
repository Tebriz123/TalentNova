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
    public class InterviewConfiguration : IEntityTypeConfiguration<Interview    >
    {
        public void Configure(EntityTypeBuilder<Interview> builder)
        {
            builder.ToTable("Interviews");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.InterviewType)
                .HasConversion<string>()
                .HasMaxLength(30);

            builder.Property(x => x.Status)
                .HasConversion<string>()
                .HasMaxLength(30);

            builder.Property(x => x.Location)
                .HasMaxLength(250);

            builder.Property(x => x.InterviewerId)
                .IsRequired();

            builder.HasOne<JobApplication>()
                .WithMany(x => x.Interviews)
                .HasForeignKey(x => x.JobApplicationId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
