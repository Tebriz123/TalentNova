using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalentNova.Domain.Entities.Enums;

namespace TalentNova.Application.DTOs.JobApplication
{
    public record GetJobApplicationDto(
        long Id,
        string CandidateFullName,
        string JobTitle,
        ApplicationStatus Status,
        DateTime AppliedDate
        );
    
}
