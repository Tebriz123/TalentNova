using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalentNova.Domain.Entities.Enums;

namespace TalentNova.Application.DTOs.Candidate
{
    public record PostCandidateDto(
        string FirstName,
        string LastName,
        string Email,
        string PhoneNumber,
        string? Address,
        string? LinkedInUrl,
        string? PortfolioUrl,
        CandidateSource Source
        );
   
}
