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
    public class InterviewFeedbackConfiguration : IEntityTypeConfiguration<InterviewFeedback>
    {
        public void Configure(EntityTypeBuilder<InterviewFeedback> builder)
        {
            builder.ToTable("InterviewFeedbacks");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Rating)
                .IsRequired();

            builder.Property(x => x.Strengths)
                .HasMaxLength(1500);

            builder.Property(x => x.Weaknesses)
                .HasMaxLength(1500);

            builder.Property(x => x.Comments)
                .HasMaxLength(2000);

            builder.Property(x => x.Recommendation)
                .HasConversion<string>()
                .HasMaxLength(30);

            builder.Property(x => x.InterviewerId)
                .IsRequired();

            builder.HasOne<Interview>()
                .WithOne()
                .HasForeignKey<InterviewFeedback>(x => x.InterviewId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasIndex(x => x.InterviewId).IsUnique();
        }
    }
}
