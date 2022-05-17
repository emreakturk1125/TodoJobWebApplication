using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;
using Ysk.Todo.Dto.DTOs.AppUserDto;

namespace Ysk.Todo.Business.ValidationRules.FluentValidation
{
    public class AppUserListValidator : AbstractValidator<AppUserListDto>
    {
        public AppUserListValidator()
        { 
            RuleFor(x => x.Email).NotNull().WithMessage("Email alanı boş geçilemez");
            RuleFor(x => x.Name).NotNull().WithMessage("Ad alanı boş geçilemez");
            RuleFor(x => x.Surname).NotNull().WithMessage("Soyad alanı boş geçilemez");
        }
    }
}
