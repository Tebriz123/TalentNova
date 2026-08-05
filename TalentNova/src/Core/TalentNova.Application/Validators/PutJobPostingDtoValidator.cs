using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalentNova.Application.DTOs.JobPosting;

namespace TalentNova.Application.Validators
{
    public class PutJobPostingDtoValidator:AbstractValidator<PutJobPostingDto>
    {
        public PutJobPostingDtoValidator()
        {
            RuleFor(x => x.Title)
                .NotEmpty().WithMessage("Vakansiya başlığı boş ola bilməz")
                .MaximumLength(150);

            RuleFor(x => x.Description)
                .NotEmpty().WithMessage("Təsvir boş ola bilməz")
                .MaximumLength(5000);

            RuleFor(x => x.Requirements)
                .NotEmpty().WithMessage("Tələblər boş ola bilməz")
                .MaximumLength(3000);

            RuleFor(x => x.SalaryMin)
                .GreaterThanOrEqualTo(0);

            RuleFor(x => x.SalaryMax)
                .GreaterThanOrEqualTo(x => x.SalaryMin)
                .WithMessage("Maksimum maaş minimumdan az ola bilməz");

            RuleFor(x => x.Status)
                .IsInEnum().WithMessage("Düzgün status seçilməyib");
        }
    }
}
