using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalentNova.Application.DTOs.AppUser
{
    public record LoginDto(
        string Email,
        string Password
        );
 
}
