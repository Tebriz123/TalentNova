using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalentNova.Domain.Entities.common;
using TalentNova.Domain.Entities.Enums;

namespace TalentNova.Domain.Entities
{
    public class ApplicationStageHistory:BaseEntity
    {
        public long JobApplicationId { get; set; }
        public JobApplication JobApplication { get; set; }
        public string ChangedByUserId { get; set; }
        public ApplicationStatus FromStatus { get; set; }
        public ApplicationStatus ToStatus { get; set; }
        public string Note { get; set; }


    }
}
