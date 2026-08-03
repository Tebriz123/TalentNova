using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalentNova.Domain.Entities.Enums;

namespace TalentNova.Application.DTOs.Offer
{
    public record GetOfferDto(
        long Id,
        string CandidateFullName,
        string Position,
        decimal SalaryOffered,
        OfferStatus Status,
        DateTime IssuedDate,
        DateTime ExpiryDate
        );
  
}
