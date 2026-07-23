using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalentNova.Domain.Entities.common;

namespace TalentNova.Domain.Entities
{
    public class WorkExperience:BaseNameableEntity
    {
        public long CandidateId { get; set; }
        public string CompanyName { get; set; }
        public string Position { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public bool IsCurrent { get; set; }
        public string Description { get; set; }
    }
}
