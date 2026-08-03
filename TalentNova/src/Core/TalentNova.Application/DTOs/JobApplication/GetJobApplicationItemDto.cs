using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalentNova.Application.DTOs.Candidate;
using TalentNova.Application.DTOs.JobPosting;
using TalentNova.Domain.Entities.Enums;

namespace TalentNova.Application.DTOs.JobApplication
{
    public record GetJobApplicationItemDto(
        long Id,
        GetCandidateDto Candidate,
        GetJobPostingDto JobPosting,
        string AssignedRecruiterName,
        ApplicationStatus ApplicationStatus,
        string CoverLetter,
        DateTime AppliedDate,
        List<ApplicationStageHistoryDto> StageHistory
        );
  
}
