using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalentNova.Domain.Entities.Enums;

namespace TalentNova.Application.DTOs.Interview
{
    public record GetInterviewDto(
        long Id,
        string CandidateFullName,
        string JobTitle,
        string InterviewerName,
        InterviewType InterviewType,
        DateTime ScheduledDate,
        InterviewStatus Status
        );
   
}
