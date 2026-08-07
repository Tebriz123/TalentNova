using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalentNova.Application.DTOs.Interview;
using TalentNova.Domain.Entities;

namespace TalentNova.Application.MappingProfiles
{
    internal class InterviewProfile : Profile
    {
        public InterviewProfile()
        {
            CreateMap<Interview, GetInterviewDto>()
        .ForCtorParam(nameof(GetInterviewDto.CandidateFullName),
            opt => opt.MapFrom(src => string.Empty))
        .ForCtorParam(nameof(GetInterviewDto.JobTitle),
            opt => opt.MapFrom(src => string.Empty))
        .ForCtorParam(nameof(GetInterviewDto.InterviewerName),
            opt => opt.MapFrom(src => string.Empty));

            CreateMap<ScheduleInterviewDto, Interview>()
                .ForMember(dest => dest.InterviewerId, opt => opt.Ignore())
                .ForMember(dest => dest.Status, opt => opt.Ignore());
        }
    }
}
