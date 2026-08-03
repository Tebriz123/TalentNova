using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalentNova.Domain.Entities.Enums;

namespace TalentNova.Application.DTOs.JobPosting
{
    public record GetJobPostingDto(
        long Id,
        string Title,
        string Location,
        EmploymentType EmploymentType,
        JobStatus JobStatus,
        int OpenPositions,
        DateTime PostedDate
        );
    
}
