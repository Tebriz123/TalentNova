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
    public class JobPostingConfiguration : IEntityTypeConfiguration<JobPosting>
    {
        public void Configure(EntityTypeBuilder<JobPosting> builder)
        {
            builder.ToTable("JobPostings");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Title)
                .IsRequired()
                .HasMaxLength(150);

            builder.Property(x => x.Description)
                .IsRequired()
                .HasColumnType("nvarchar(max)");

            builder.Property(x => x.Requirements)
                .HasColumnType("nvarchar(max)");

            builder.Property(x => x.Location)
                .HasMaxLength(150);

            builder.Property(x => x.SalaryMin)
                .HasColumnType("decimal(18,2)");

            builder.Property(x => x.SalaryMax)
                .HasColumnType("decimal(18,2)");

            builder.Property(x => x.EmploymentType)
                .HasConversion<string>()
                .HasMaxLength(30);

            builder.Property(x => x.Status)
                .HasConversion<string>()
                .HasMaxLength(30);

            builder.HasOne<Department>()
                .WithMany()
                .HasForeignKey(x => x.DepartmentId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne<Company>()
                .WithMany()
                .HasForeignKey(x => x.CompanyId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Property(x => x.CreatedByUserId)
                .IsRequired();

            builder.HasIndex(x => x.Status);
        }
    }
}
