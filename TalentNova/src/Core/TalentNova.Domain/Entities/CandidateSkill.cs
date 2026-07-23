using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalentNova.Domain.Entities.common;

namespace TalentNova.Domain.Entities
{
    public class CandidateSkill:BaseNameableEntity
    {
        public long CondidateId { get; set; }
        public long SkillId { get; set; }
    }
}
