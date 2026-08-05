using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalentNova.Application.DTOs.Interview;

namespace TalentNova.Application.Validators
{
    public class ScheduleInterviewDtoValidator:AbstractValidator<ScheduleInterviewDto>
    {
        public ScheduleInterviewDtoValidator()
        {
            RuleFor(x => x.JobApplicationId)
                .GreaterThan(0).WithMessage("Müraciət seçilməlidir");

            RuleFor(x => x.InterviewerId)
                .NotEmpty().WithMessage("Müsahibəçi seçilməlidir");

            RuleFor(x => x.InterviewType)
                .IsInEnum().WithMessage("Düzgün müsahibə növü seçilməyib");

            RuleFor(x => x.ScheduledDate)
                .GreaterThan(DateTime.UtcNow)
                .WithMessage("Müsahibə tarixi gələcəkdə olmalıdır");

            RuleFor(x => x.DurationMinutes)
                .InclusiveBetween(15, 240)
                .WithMessage("Müddət 15-240 dəqiqə arasında olmalıdır");

            RuleFor(x => x.Location)
                .MaximumLength(250);
        }
    }
}
