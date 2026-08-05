using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalentNova.Application.DTOs.Offer;

namespace TalentNova.Application.Validators
{
    public class PostOfferDtoValidator:AbstractValidator<PostOfferDto>
    {
        public PostOfferDtoValidator()
        {
            RuleFor(x => x.JobApplicationId)
          .GreaterThan(0);

            RuleFor(x => x.Position)
                .NotEmpty().WithMessage("Vəzifə adı boş ola bilməz")
                .MaximumLength(100);

            RuleFor(x => x.SalaryOffered)
                .GreaterThan(0).WithMessage("Təklif olunan maaş 0-dan böyük olmalıdır");

            RuleFor(x => x.StartDate)
                .GreaterThan(DateTime.UtcNow)
                .WithMessage("Başlama tarixi gələcəkdə olmalıdır");

            RuleFor(x => x.ExpiryDate)
                .GreaterThan(DateTime.UtcNow)
                .WithMessage("Bitmə tarixi gələcəkdə olmalıdır")
                .LessThanOrEqualTo(x => x.StartDate)
                .WithMessage("Bitmə tarixi başlama tarixindən sonra ola bilməz");
        }
    }
}
