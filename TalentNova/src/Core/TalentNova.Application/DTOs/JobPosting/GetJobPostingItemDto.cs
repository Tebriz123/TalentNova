using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalentNova.Domain.Entities.Enums;

namespace TalentNova.Application.DTOs.JobPosting
{
    public record GetJobPostingItemDto(
        long Id,
        string Title,
        string Description,
        string Requirements,
        string Location,
        EmploymentType EmploymentType,
        decimal SalaryMin,
        decimal SalaryMax,
        int OpenPositions,
        JobStatus Status,
        DateTime PostedDate,
        DateTime? ClosingDate,
        int TotalApplications
        );
   
}
