using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalentNova.Application.DTOs.Notification;
using TalentNova.Domain.Entities;

namespace TalentNova.Application.MappingProfiles
{
    public class NotificationProfile : Profile
    {
        public NotificationProfile()
        {
            CreateMap<Notification, GetNotificationDto>()
                .ForCtorParam(nameof(GetNotificationDto.CreatedDate),
                    opt => opt.MapFrom(src => src.CreatedAt));   
        }
    }
}
