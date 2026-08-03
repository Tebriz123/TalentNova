using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalentNova.Domain.Entities.Enums;

namespace TalentNova.Application.DTOs.JobPosting
{
    public record PostJobPostingDto(
        string Title,
        string Description,
        string Requirements,
        long DepartmentId,
        EmploymentType EmploymentType,
        string Location,
        decimal SalaryMin,
        decimal SalaryMax,
        int OpenPositions,
        DateTime? ClosingDate
        );
  
}
