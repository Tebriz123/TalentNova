using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalentNova.Application.DTOs.WorkExperience;
using TalentNova.Domain.Entities;

namespace TalentNova.Application.MappingProfiles
{
    public class WorkExperienceProfile : Profile
    {
        public WorkExperienceProfile()
        {
            CreateMap<WorkExperience, GetWorkExperienceDto>()
                .ForCtorParam(nameof(GetWorkExperienceDto.StartDate),
                    opt => opt.MapFrom(src => src.StartTime))
                .ForCtorParam(nameof(GetWorkExperienceDto.EndDate),
                    opt => opt.MapFrom(src => src.EndTime));
        }
    }
}
