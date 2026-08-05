using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalentNova.Domain.Entities.common;
using TalentNova.Domain.Entities.Enums;

namespace TalentNova.Domain.Entities
{
    public class Offer:BaseEntity
    {
        public long JobApplicationId { get; set; }
        public string IssuedByUserId { get; set; }
        public string Position { get; set; }
        public decimal SalaryOffered { get; set; }
        public OfferStatus Status { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime ExpiryDate { get; set; }
        public DateTime IssuedDate { get; set; }
    }

}
