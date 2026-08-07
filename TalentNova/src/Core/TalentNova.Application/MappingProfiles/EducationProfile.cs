using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalentNova.Application.DTOs.Education;
using TalentNova.Domain.Entities;

namespace TalentNova.Application.MappingProfiles
{
    public class EducationProfile : Profile
    {
        public EducationProfile()
        {
            CreateMap<Education, GetEducationDto>();
        }
    }
}
