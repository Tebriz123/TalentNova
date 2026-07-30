using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalentNova.Domain.Entities.common;

namespace TalentNova.Domain.Entities
{
    public class Interview:BaseEntity
    {
        public long JobApllicationId { get; set; }
        public long InterviewId { get; set; }
        public DateTime ScheduledDate { get; set; }
        public int DurationMinutes { get; set; }
        public string Location { get; set; }

    }
}
