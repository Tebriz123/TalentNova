using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalentNova.Application.DTOs.Education
{
    public record GetEducationDto(
        long Id,
        string UniversitateName,
        string Degree,
        string FieldOfStudy,
        DateTime StartDate,
        DateTime? EndDate
        );
   
}
