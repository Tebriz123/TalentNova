using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalentNova.Application.DTOs.Offer;

namespace TalentNova.Application.Validators
{
    public class PutOfferDtoValidator:AbstractValidator<PutOfferDto>
    {
        public PutOfferDtoValidator()
        {
            RuleFor(x => x.OfferId)
           .GreaterThan(0);

            RuleFor(x => x.Status)
                .IsInEnum().WithMessage("Düzgün status seçilməyib");
        }
    }
}
