using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalentNova.Application.DTOs.JobApplication;

namespace TalentNova.Application.Validators
{
    public class MoveApplicationStageDtoValidator: AbstractValidator<MoveApplicationStageDto>
    {
        public MoveApplicationStageDtoValidator()
        {
            RuleFor(x => x.ApplicationId)
                .GreaterThan(0);

            RuleFor(x => x.NewStatus)
                .IsInEnum().WithMessage("Düzgün status seçilməyib");

            RuleFor(x => x.Note)
                .MaximumLength(1000);
        }
    }
}
