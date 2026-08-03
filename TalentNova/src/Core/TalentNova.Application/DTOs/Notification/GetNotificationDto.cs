using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalentNova.Domain.Entities.Enums;

namespace TalentNova.Application.DTOs.Notification
{
    public record GetNotificationDto(
        long Id,
        string Title,
        string Message,
        NotificationType Type,
        bool IsRead,
        DateTime CreatedDate
        );
   
}
