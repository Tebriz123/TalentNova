using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalentNova.Application.DTOs.Offer
{
    public record PostOfferDto(
        long JobApplicationId,
        string Position,
        decimal SalaryOffered,
        DateTime StartDate,
        DateTime ExpiryDate
        );

}
