using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalentNova.Domain.Entities.common;

namespace TalentNova.Domain.Entities
{
    public class ApplicationStageHistory:BaseEntity
    {
        public long JobApplicationId { get; set; }
        public string ChangedByUserId { get; set; }
        public string Note { get; set; }


    }
}
