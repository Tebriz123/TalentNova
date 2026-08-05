using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalentNova.Domain.Entities.Enums;

namespace TalentNova.Application.DTOs.Offer
{
    public record PutOfferDto(
        long OfferId,
        OfferStatus Status
        );
   
}
