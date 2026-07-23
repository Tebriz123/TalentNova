using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalentNova.Domain.Entities.common
{
    public class BaseNameableEntity:BaseAccountableEntity
    {
        public string Name { get; set; }    
    }
}
