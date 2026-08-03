using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalentNova.Domain.Entities.Enums;

namespace TalentNova.Application.DTOs.Interview
{
    public record ScheduleInterviewDto(
        long JobApplicationId,
        string InterviewerId,
        InterviewType InterviewType,
        DateTime ScheduledDate,
        int DurationMinutes,
        string? Location
        );
   
}
