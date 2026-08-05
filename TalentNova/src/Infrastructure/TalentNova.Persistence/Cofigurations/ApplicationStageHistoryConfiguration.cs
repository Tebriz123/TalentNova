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
    public class ApplicationStageHistoryConfiguration : IEntityTypeConfiguration<ApplicationStageHistory>
    {
        public void Configure(EntityTypeBuilder<ApplicationStageHistory> builder)
        {
            builder.ToTable("ApplicationStageHistories");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.FromStatus)
                .HasConversion<string>()
                .HasMaxLength(30);

            builder.Property(x => x.ToStatus)
                .HasConversion<string>()
                .HasMaxLength(30);

            builder.Property(x => x.Note)
                .HasMaxLength(1000);

            builder.Property(x => x.ChangedByUserId)
                .IsRequired();

            builder.HasOne<JobApplication>()
                .WithMany(x => x.StageHistories)
                .HasForeignKey(x => x.JobApplicationId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
