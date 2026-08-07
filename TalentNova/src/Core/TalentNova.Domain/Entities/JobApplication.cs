using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalentNova.Domain.Entities.common;
using TalentNova.Domain.Entities.Enums;

namespace TalentNova.Domain.Entities
{
    public class JobApplication:BaseAccountableEntity
    {
        public long CandidateId { get; set; }
        public long JobPostingId { get; set; }
        public long AssignedRecruiterId { get; set; }
        public ICollection<Interview> Interviews { get; set; } = new List<Interview>();
        public ICollection<ApplicationStageHistory> StageHistories { get; set; } = new List<ApplicationStageHistory>();
        public string CoverLetter { get; set; }
        public ApplicationStatus Status { get; set; }


    }
}
