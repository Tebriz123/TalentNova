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
    public class CandidateConfiguration : IEntityTypeConfiguration<Candidate>
    {
        public void Configure(EntityTypeBuilder<Candidate> builder)
        {
            builder.ToTable("Candidates");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.AppUserId)
                .IsRequired();

            builder.Property(x => x.PhotoUrl)
                .HasMaxLength(500);

            builder.Property(x => x.Address)
                .HasMaxLength(250);

            builder.Property(x => x.LinkedInUrl)
                .HasMaxLength(300);

            builder.Property(x => x.PortfolioUrl)
                .HasMaxLength(300);

            builder.Property(x => x.CurrentPosition)
                .HasMaxLength(150);

            builder.Property(x => x.CurrentCompany)
                .HasMaxLength(150);

            builder.Property(x => x.Source)
                .HasConversion<string>()
                .HasMaxLength(30);

            builder.HasOne<AppUser>()
                .WithOne()
                .HasForeignKey<Candidate>(x => x.AppUserId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasIndex(x => x.AppUserId).IsUnique();
        }
    } 
}
