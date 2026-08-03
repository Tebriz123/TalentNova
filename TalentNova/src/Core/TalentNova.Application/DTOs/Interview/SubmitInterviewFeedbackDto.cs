using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalentNova.Domain.Entities.Enums;

namespace TalentNova.Application.DTOs.Interview
{
    public record SubmitInterviewFeedbackDto(
        long InterviewId,
        int Rating,
        string? Strengths,
        string? Weaknesses,
        RecommendationType Recommendation,
        string? Comments
        );
  
}
