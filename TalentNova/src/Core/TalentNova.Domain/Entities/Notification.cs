using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalentNova.Domain.Entities.common;

namespace TalentNova.Domain.Entities
{
    public class Notification:BaseAccountableEntity
    {
        public string UserId { get; set; }
        public string Title { get; set; }
        public string Message { get; set; }
        public bool IsRead { get; set; }    

    }
}
