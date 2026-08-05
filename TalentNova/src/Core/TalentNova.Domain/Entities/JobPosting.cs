using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalentNova.Domain.Entities.common;
using TalentNova.Domain.Entities.Enums;

namespace TalentNova.Domain.Entities
{
    public class JobPosting:BaseNameableEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Requirements { get; set; }
        public long DepartmentId { get; set; }
        public long CompanyId { get; set; }
        public string CreatedByUserId { get; set; }
        public EmploymentType EmploymentType { get; set; }
        public string Location { get; set; }
        public decimal SalaryMin { get; set; }
        public decimal SalaryMax { get; set; }
        public int OpenPositions { get; set; }
        public JobStatus Status { get; set; }
        public DateTime PostedDate { get; set; }
        public DateTime? ClosingDate { get; set; }
    }
}
