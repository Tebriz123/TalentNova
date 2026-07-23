using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalentNova.Domain.Entities.common;

namespace TalentNova.Domain.Entities
{
    public class Candidate:BaseNameableEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string LinkedInUrl { get; set; }
        public string PortfolioUrl { get; set; }
        public string CurrentPosition { get; set; }
        public string CurrentCompany { get; set; }
    }
}
