using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalentNova.Domain.Entities.common;

namespace TalentNova.Domain.Entities
{
    public class Resume:BaseNameableEntity
    {
        public long CandidateId { get; set; }
        public string FileName { get; set; }
        public string FileUrl { get; set; }
        public string? ParsedText { get; set; }
    }
}
