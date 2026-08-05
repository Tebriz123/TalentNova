using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalentNova.Application.DTOs.Candidate
{
    public record PutCandidateDto(
        string FirstName,
        string LastName,
        string PhoneNumber,
        IFormFile? Photo,
        string? Address,
        string? LinkedInUrl,
        string? PortfolioUrl
        );
    
}
