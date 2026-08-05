using FluentValidation;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalentNova.Application.DTOs.Candidate;

namespace TalentNova.Application.Validators
{
    public class PostCandidateDtoValidator:AbstractValidator<PostCandidateDto>
    {
        private readonly string[] _allowedPhotoExtensions = { ".jpg", ".jpeg", ".png", ".webp" };
        private const int MaxPhotoSizeMb = 2;

        public PostCandidateDtoValidator()
        {
            RuleFor(x => x.FirstName)
                .NotEmpty().WithMessage("Ad boş ola bilməz")
                .MaximumLength(50).WithMessage("Ad 50 simvoldan uzun ola bilməz");

            RuleFor(x => x.LastName)
                .NotEmpty().WithMessage("Soyad boş ola bilməz")
                .MaximumLength(50).WithMessage("Soyad 50 simvoldan uzun ola bilməz");

            RuleFor(x => x.Email)
                .NotEmpty().WithMessage("Email boş ola bilməz")
                .EmailAddress().WithMessage("Email formatı düzgün deyil")
                .MaximumLength(100);

            RuleFor(x => x.PhoneNumber)
                .NotEmpty().WithMessage("Telefon nömrəsi boş ola bilməz")
                .Matches(@"^\+?[0-9]{9,15}$").WithMessage("Telefon nömrəsi formatı düzgün deyil");

            RuleFor(x => x.Photo)
                .Must(HaveValidExtension).When(x => x.Photo != null)
                .WithMessage("Yalnız JPG, JPEG, PNG, WEBP formatlarına icazə verilir")
                .Must(HaveValidSize).When(x => x.Photo != null)
                .WithMessage($"Şəkil ölçüsü {MaxPhotoSizeMb}MB-dan çox ola bilməz");

            RuleFor(x => x.Address)
                .MaximumLength(250);

            RuleFor(x => x.LinkedInUrl)
                .Must(BeAValidUrl).When(x => !string.IsNullOrEmpty(x.LinkedInUrl))
                .WithMessage("LinkedIn linki düzgün URL formatında olmalıdır");

            RuleFor(x => x.PortfolioUrl)
                .Must(BeAValidUrl).When(x => !string.IsNullOrEmpty(x.PortfolioUrl))
                .WithMessage("Portfolio linki düzgün URL formatında olmalıdır");

            RuleFor(x => x.Source)
                .IsInEnum().WithMessage("Düzgün mənbə (Source) seçilməyib");
        }

        private bool HaveValidExtension(IFormFile? file)
        {
            if (file == null) return true;
            var ext = Path.GetExtension(file.FileName).ToLowerInvariant();
            return _allowedPhotoExtensions.Contains(ext);
        }

        private bool HaveValidSize(IFormFile? file)
        {
            if (file == null) return true;
            return file.Length <= MaxPhotoSizeMb * 1024 * 1024;
        }

        private bool BeAValidUrl(string? url) =>
            Uri.TryCreate(url, UriKind.Absolute, out _);
    }
}
