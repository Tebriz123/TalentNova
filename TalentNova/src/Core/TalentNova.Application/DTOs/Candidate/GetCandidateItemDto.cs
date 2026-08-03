using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalentNova.Application.DTOs.Candidate
{
    public record GetCandidateItemDto(
        long Id,
        string FirstName,
        string LastName,
        string PhoneNumber,
        string Email,
        string? LinkedInUrl,
        List<string> Skills
        );
    
}
