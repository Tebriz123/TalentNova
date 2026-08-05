using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalentNova.Domain.Entities.common;
using TalentNova.Domain.Entities.Enums;

namespace TalentNova.Domain.Entities
{
    public class CandidateSkill:BaseNameableEntity
    {
        public long CandidateId { get; set; }
        public long SkillId { get; set; }
        public ProficiencyLevel? ProficiencyLevel { get; set; }
    }
}
