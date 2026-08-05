using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalentNova.Domain.Entities.common;
using TalentNova.Domain.Entities.Enums;

namespace TalentNova.Domain.Entities
{
    public class Interview:BaseEntity
    {
        public long JobApplicationId { get; set; }
        public JobApplication JobApplication { get; set; }
        public long InterviewerId { get; set; }
        public InterviewType InterviewType { get; set; }
        public DateTime ScheduledDate { get; set; }
        public int DurationMinutes { get; set; }
        public string Location { get; set; }
        public InterviewStatus Status { get; set; }

    }
}
