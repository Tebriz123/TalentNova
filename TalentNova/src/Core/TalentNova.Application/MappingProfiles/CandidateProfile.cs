using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalentNova.Application.DTOs.Candidate;
using TalentNova.Domain.Entities;

namespace TalentNova.Application.MappingProfiles
{
    internal class CandidateProfile:Profile
    {
        public CandidateProfile()
        {
            CreateMap<Candidate, GetCandidateItemDto>()
          .ForCtorParam(nameof(GetCandidateItemDto.FirstName),
              opt => opt.MapFrom(src => src.AppUser.Name))
          .ForCtorParam(nameof(GetCandidateItemDto.LastName),
              opt => opt.MapFrom(src => src.AppUser.Surname))
          .ForCtorParam(nameof(GetCandidateItemDto.Photo),
              opt => opt.MapFrom(src => src.PhotoUrl))
          .ForCtorParam(nameof(GetCandidateItemDto.PhoneNumber),
              opt => opt.MapFrom(src => src.AppUser.PhoneNumber))
          .ForCtorParam(nameof(GetCandidateItemDto.Email),
              opt => opt.MapFrom(src => src.AppUser.Email));
             
            CreateMap<Candidate, GetCandidateDto>()
                .ForCtorParam(nameof(GetCandidateDto.FirstName),
                    opt => opt.MapFrom(src => src.AppUser.Name))
                .ForCtorParam(nameof(GetCandidateDto.LastName),
                    opt => opt.MapFrom(src => src.AppUser.Surname))
                .ForCtorParam(nameof(GetCandidateDto.Photo),
                    opt => opt.MapFrom(src => src.PhotoUrl))
                .ForCtorParam(nameof(GetCandidateDto.PhoneNumber),
                    opt => opt.MapFrom(src => src.AppUser.PhoneNumber))
                .ForCtorParam(nameof(GetCandidateDto.Email),
                    opt => opt.MapFrom(src => src.AppUser.Email));

            CreateMap<PostCandidateDto, Candidate>()
                .ForMember(dest => dest.PhotoUrl, opt => opt.Ignore())
                .ForMember(dest => dest.AppUserId, opt => opt.Ignore());

            CreateMap<PutCandidateDto, Candidate>()
                .ForMember(dest => dest.PhotoUrl, opt => opt.Ignore())
                .ForMember(dest => dest.AppUserId, opt => opt.Ignore())
                .ForMember(dest => dest.Source, opt => opt.Ignore())
                .ForMember(dest => dest.CreatedAt, opt => opt.Ignore());
        }
    }
}
