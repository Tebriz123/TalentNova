using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalentNova.Application.DTOs.Resume
{
    public record GetResumeDto(
        long Id,
        string FileName,
        string FileUrl,
        DateTime UploadedDate
        );
   
}
