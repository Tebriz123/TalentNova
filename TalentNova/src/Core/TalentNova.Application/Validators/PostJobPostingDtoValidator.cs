using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalentNova.Application.DTOs.JobPosting;

namespace TalentNova.Application.Validators
{
    public class PostJobPostingDtoValidator:AbstractValidator<PostJobPostingDto>
    {
        public PostJobPostingDtoValidator()
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

            RuleFor(x => x.DepartmentId)
                .GreaterThan(0).WithMessage("Şöbə seçilməlidir");

            RuleFor(x => x.EmploymentType)
                .IsInEnum().WithMessage("Düzgün işə qəbul növü seçilməyib");

            RuleFor(x => x.Location)
                .NotEmpty().WithMessage("Lokasiya boş ola bilməz")
                .MaximumLength(150);

            RuleFor(x => x.SalaryMin)
                .GreaterThanOrEqualTo(0).WithMessage("Minimum maaş mənfi ola bilməz");

            RuleFor(x => x.SalaryMax)
                .GreaterThanOrEqualTo(x => x.SalaryMin)
                .WithMessage("Maksimum maaş minimumdan az ola bilməz");

            RuleFor(x => x.OpenPositions)
                .GreaterThan(0).WithMessage("Boş yer sayı ən azı 1 olmalıdır");

            RuleFor(x => x.ClosingDate)
                .GreaterThan(DateTime.UtcNow)
                .When(x => x.ClosingDate.HasValue)
                .WithMessage("Bağlanma tarixi bu gündən sonra olmalıdır");
        }
    }
}
