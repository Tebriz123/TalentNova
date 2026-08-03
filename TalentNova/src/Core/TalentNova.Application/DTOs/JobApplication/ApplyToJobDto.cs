using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalentNova.Application.DTOs.JobApplication
{
    public record ApplyToJobDto(
        long CandidateId,
        long JobPostingId,
        string? CoverLetter
        );
    
}
