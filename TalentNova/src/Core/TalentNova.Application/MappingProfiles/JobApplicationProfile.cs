using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalentNova.Application.DTOs.Candidate;
using TalentNova.Application.DTOs.JobApplication;
using TalentNova.Application.DTOs.JobPosting;
using TalentNova.Domain.Entities;

namespace TalentNova.Application.MappingProfiles
{
    public class JobApplicationProfile : Profile
    {
        public JobApplicationProfile()
        {
            CreateMap<JobApplication, GetJobApplicationDto>()
                .ForCtorParam(nameof(GetJobApplicationDto.CandidateFullName),
                    opt => opt.MapFrom(src => string.Empty))
                .ForCtorParam(nameof(GetJobApplicationDto.JobTitle),
                    opt => opt.MapFrom(src => string.Empty))
                .ForCtorParam(nameof(GetJobApplicationDto.AppliedDate),
                    opt => opt.MapFrom(src => src.CreatedAt));  

            // Entity → GetJobApplicationItemDto (tam detal)
            CreateMap<JobApplication, GetJobApplicationItemDto>()
                .ForCtorParam(nameof(GetJobApplicationItemDto.Candidate),
                    opt => opt.MapFrom(src => (GetCandidateDto)null))        
                .ForCtorParam(nameof(GetJobApplicationItemDto.JobPosting),
                    opt => opt.MapFrom(src => (GetJobPostingDto)null))       
                .ForCtorParam(nameof(GetJobApplicationItemDto.AssignedRecruiterName),
                    opt => opt.MapFrom(src => string.Empty))                
                .ForCtorParam(nameof(GetJobApplicationItemDto.ApplicationStatus),
                    opt => opt.MapFrom(src => src.Status))                    
                .ForCtorParam(nameof(GetJobApplicationItemDto.AppliedDate),
                    opt => opt.MapFrom(src => src.CreatedAt))
                .ForCtorParam(nameof(GetJobApplicationItemDto.StageHistory),
                    opt => opt.MapFrom(src => src.StageHistories));         

            // ApplyToJobDto → JobApplication
            CreateMap<ApplyToJobDto, JobApplication>()
                .ForMember(dest => dest.AssignedRecruiterId, opt => opt.Ignore())  
                .ForMember(dest => dest.Status, opt => opt.Ignore());            
        }
    }
}
