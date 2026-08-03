  using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalentNova.Domain.Entities.Enums;

namespace TalentNova.Application.DTOs.JobPosting
{
    public record PutJobPostingDto(
        string Title,
        string Description,
        string Requirements,
        decimal SalaryMin,
        decimal SalaryMax,
        JobStatus Status
        );
    
}
