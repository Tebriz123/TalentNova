using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalentNova.Application.DTOs.Resume;
using TalentNova.Domain.Entities;

namespace TalentNova.Application.MappingProfiles
{
    public class ResumeProfile : Profile
    {
        public ResumeProfile()
        {
            CreateMap<Resume, GetResumeDto>()
                .ForCtorParam(nameof(GetResumeDto.UploadedDate),
                    opt => opt.MapFrom(src => src.CreatedAt));   
        }
    }
}
