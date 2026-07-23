using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalentNova.Domain.Entities.common;

namespace TalentNova.Domain.Entities
{
    public class JobPosting:BaseNameableEntity
    {
        public string Description { get; set; }
        public string Requirements { get; set; }
        public long CompanyId { get; set; }
        public long DepartmentId { get; set; }
        public string CreatedByUserId { get; set; }
        public string Location { get; set; }
        public decimal MinSalary { get; set; }
        public decimal MaxSalary { get; set; }
        public int OpenPositions { get; set; }
        public DateTime? ClosingDate { get; set; }
    }
}
