using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;
using Ysk.Todo.Dto.DTOs.AppUserDto;

namespace Ysk.Todo.Business.ValidationRules.FluentValidation
{
    public class AppUserSignInValidator : AbstractValidator<AppUserSignInDto>
    {
        public AppUserSignInValidator()
        {
            RuleFor(x => x.UserName).NotNull().WithMessage("Kullanıcı adı boş geçilemez");
            RuleFor(x => x.Password).NotNull().WithMessage("Parola alanı boş geçilemez"); 
        }
    }
}
