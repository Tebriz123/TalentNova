using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalentNova.Application.DTOs.Education;
using TalentNova.Application.DTOs.Resume;
using TalentNova.Application.DTOs.WorkExperience;

namespace TalentNova.Application.DTOs.Candidate
{
    public record GetCandidateItemDto(
        long Id,
        string FirstName,
        string LastName,
        string Photo,
        string PhoneNumber,
        string Email,
        string? LinkedInUrl,
        List<GetResumeDto> Resumes,
        List<GetWorkExperienceDto> WorkExperiences,
        List<GetEducationDto> Educations,
        List<string> Skills
        );
    
}
