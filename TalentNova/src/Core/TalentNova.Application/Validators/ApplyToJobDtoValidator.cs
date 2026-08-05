using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalentNova.Application.DTOs.JobApplication;

namespace TalentNova.Application.Validators
{
    public class ApplyToJobDtoValidator: AbstractValidator<ApplyToJobDto>
    {
        public ApplyToJobDtoValidator()
        {
            RuleFor(x => x.CandidateId)
                .GreaterThan(0).WithMessage("Namizəd seçilməlidir");

            RuleFor(x => x.JobPostingId)
                .GreaterThan(0).WithMessage("Vakansiya seçilməlidir");

            RuleFor(x => x.CoverLetter)
                .MaximumLength(3000).WithMessage("Cover letter 3000 simvoldan uzun ola bilməz");
        }
    }
}
