using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalentNova.Application.DTOs.WorkExperience
{
    public record GetWorkExperienceDto(
        long Id,
        string CompanyName,
        string Position,
        DateTime StartDate,
        DateTime? EndDate,
        bool IsCurrent,
        string? Description
        );
   
}
