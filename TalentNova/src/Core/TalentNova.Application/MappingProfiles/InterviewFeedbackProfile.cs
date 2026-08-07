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
    public class InterviewFeedbackProfile : Profile
    {
        public InterviewFeedbackProfile()
        {
            CreateMap<InterviewFeedback, InterviewFeedbackDto>();

            CreateMap<SubmitInterviewFeedbackDto, InterviewFeedback>()
                .ForMember(dest => dest.InterviewerId, opt => opt.Ignore())
                .ForMember(dest => dest.SubmittedDate, opt => opt.Ignore());
        }
    }
}
