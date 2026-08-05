using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalentNova.Domain.Entities.common;
using TalentNova.Domain.Entities.Enums;

namespace TalentNova.Domain.Entities
{
    public class InterviewFeedback:BaseEntity
    {
        public long InterviewId { get; set; }
        public long InterviewerId { get; set; }
        public int Rating { get; set; }
        public string Strengths { get; set; }
        public string Weaknesses { get; set; }
        public RecommendationType Recommendation { get; set; }
        public string Comments { get; set; }
        public DateTime SubmittedDate { get; set; }

    }
}
