using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalentNova.Application.DTOs.Interview;

namespace TalentNova.Application.Validators
{
    public class SubmitInterviewFeedbackDtoValidator:AbstractValidator<SubmitInterviewFeedbackDto>
    {
        public SubmitInterviewFeedbackDtoValidator()
        {
            RuleFor(x => x.InterviewId)
                .GreaterThan(0);

            RuleFor(x => x.Rating)
                .InclusiveBetween(1, 5)
                .WithMessage("Qiymətləndirmə 1-5 arasında olmalıdır");

            RuleFor(x => x.Strengths)
                .MaximumLength(1500);

            RuleFor(x => x.Weaknesses)
                .MaximumLength(1500);

            RuleFor(x => x.Recommendation)
                .IsInEnum().WithMessage("Düzgün tövsiyə seçilməyib");

            RuleFor(x => x.Comments)
                .MaximumLength(2000);
        }
    }
}
