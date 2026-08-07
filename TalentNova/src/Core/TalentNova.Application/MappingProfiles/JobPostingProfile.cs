using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalentNova.Application.DTOs.JobPosting;
using TalentNova.Domain.Entities;

namespace TalentNova.Application.MappingProfiles
{
    public class JobPostingProfile : Profile
    {
        public JobPostingProfile()
        {
            CreateMap<JobPosting, GetJobPostingDto>()
                .ForCtorParam(nameof(GetJobPostingDto.JobStatus),
                    opt => opt.MapFrom(src => src.Status));

            CreateMap<JobPosting, GetJobPostingItemDto>()
                .ForCtorParam(nameof(GetJobPostingItemDto.TotalApplications),
                    opt => opt.MapFrom(src => 0));

            CreateMap<PostJobPostingDto, JobPosting>()
                .ForMember(dest => dest.CompanyId, opt => opt.Ignore())
                .ForMember(dest => dest.CreatedByUserId, opt => opt.Ignore())
                .ForMember(dest => dest.Status, opt => opt.Ignore())
                .ForMember(dest => dest.PostedDate, opt => opt.Ignore());

            CreateMap<PutJobPostingDto, JobPosting>();
        }
    }
}
