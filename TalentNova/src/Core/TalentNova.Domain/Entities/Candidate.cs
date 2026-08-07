using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalentNova.Domain.Entities.common;
using TalentNova.Domain.Entities.Enums;

namespace TalentNova.Domain.Entities
{
    public class Candidate:BaseNameableEntity
    {
        public string AppUserId { get; set; }
        public AppUser AppUser { get; set; }
        public string? PhotoUrl { get; set; }
        public string? Address { get; set; }
        public string? LinkedInUrl { get; set; }
        public string? PortfolioUrl { get; set; }
        public string? CurrentPosition { get; set; }
        public string? CurrentCompany { get; set; }
        public CandidateSource Source { get; set; }
    }
}
