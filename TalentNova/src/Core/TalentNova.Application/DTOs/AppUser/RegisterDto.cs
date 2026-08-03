using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalentNova.Application.DTOs.AppUser
{
    public record RegisterDto(
        string Name,
        string Surname,
        string Email,
        string Password
        );
    
}
