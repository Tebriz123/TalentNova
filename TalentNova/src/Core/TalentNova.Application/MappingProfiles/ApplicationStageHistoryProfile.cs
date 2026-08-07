using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalentNova.Application.DTOs.JobApplication;
using TalentNova.Domain.Entities;


namespace TalentNova.Application.MappingProfiles
{
    public class ApplicationStageHistoryProfile : Profile
    {
        public ApplicationStageHistoryProfile()
        {
            CreateMap<ApplicationStageHistory, ApplicationStageHistoryDto>()
                .ForCtorParam(nameof(ApplicationStageHistoryDto.ChangedByUserName),
                    opt => opt.MapFrom(src => string.Empty))     
                .ForCtorParam(nameof(ApplicationStageHistoryDto.ChangedDate),
                    opt => opt.MapFrom(src => src.CreatedAt));   
        }
    }
}
