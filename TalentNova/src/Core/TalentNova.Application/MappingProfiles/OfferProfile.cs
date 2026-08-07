using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalentNova.Application.DTOs.Offer;
using TalentNova.Domain.Entities;

namespace TalentNova.Application.MappingProfiles
{
    internal class OfferProfile:Profile
    {
       
            public OfferProfile()
            {
                CreateMap<Offer, GetOfferDto>()
                    .ForCtorParam(nameof(GetOfferDto.CandidateFullName),
                        opt => opt.MapFrom(src => string.Empty));

                CreateMap<PostOfferDto, Offer>()
                    .ForMember(dest => dest.IssuedByUserId, opt => opt.Ignore())
                    .ForMember(dest => dest.Status, opt => opt.Ignore())
                    .ForMember(dest => dest.IssuedDate, opt => opt.Ignore());

                CreateMap<PutOfferDto, Offer>()
                    .ForMember(dest => dest.Id, opt => opt.Ignore());
            }
        

    }
}
