﻿using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;
using Ysk.Todo.Dto.DTOs.AppUserDto;

namespace Ysk.Todo.Business.ValidationRules.FluentValidation
{
    public class AppUserAddValidator : AbstractValidator<AppUserAddDto>
    {
        public AppUserAddValidator()
        {
            RuleFor(x => x.UserName).NotNull().WithMessage("Kullanıcı adı boş geçilemez");
            RuleFor(x => x.Password).NotNull().WithMessage("Parola alanı boş geçilemez");
            RuleFor(x => x.ConfirmPassword).NotNull().WithMessage("Parola onay alanı boş geçilemez");
            RuleFor(x => x.ConfirmPassword).Equal(x => x.Password).WithMessage("Parolalarınız eşleşmiyor");
            RuleFor(x => x.Email).NotNull().WithMessage("Email alanı boş geçilemez");
            RuleFor(x => x.Name).NotNull().WithMessage("Ad alanı boş geçilemez");
            RuleFor(x => x.Surname).NotNull().WithMessage("Soyad alanı boş geçilemez");
        }
    }
}
