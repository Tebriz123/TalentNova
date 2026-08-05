using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalentNova.Application.DTOs.AppUser;

namespace TalentNova.Application.Validators
{
    public class RegisterDtoValidator : AbstractValidator<RegisterDto>
    {
        public RegisterDtoValidator()
        {
            RuleFor(x => x.Name)
         .NotEmpty().WithMessage("Ad boş ola bilməz")
         .MaximumLength(50);

            RuleFor(x => x.Surname)
                .NotEmpty().WithMessage("Soyad boş ola bilməz")
                .MaximumLength(50);

            RuleFor(x => x.Email)
                .NotEmpty().WithMessage("Email boş ola bilməz")
                .EmailAddress().WithMessage("Email formatı düzgün deyil");

            RuleFor(x => x.Password)
                .NotEmpty().WithMessage("Şifrə boş ola bilməz")
                .MinimumLength(8).WithMessage("Şifrə ən azı 8 simvol olmalıdır")
                .Matches("[A-Z]").WithMessage("Şifrədə ən azı 1 böyük hərf olmalıdır")
                .Matches("[a-z]").WithMessage("Şifrədə ən azı 1 kiçik hərf olmalıdır")
                .Matches("[0-9]").WithMessage("Şifrədə ən azı 1 rəqəm olmalıdır");

        }
    }
}
