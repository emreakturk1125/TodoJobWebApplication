using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;
using Ysk.Todo.Dto.DTOs.UrgencyDto;

namespace Ysk.Todo.Business.ValidationRules.FluentValidation
{
    public class UrgencyUpdateValidator : AbstractValidator<UrgencyUpdateDto>
    {
        public UrgencyUpdateValidator()
        {
            RuleFor(x => x.Description).NotNull().WithMessage("Tanım alanı boş geçilemez");
        }
    }
}
