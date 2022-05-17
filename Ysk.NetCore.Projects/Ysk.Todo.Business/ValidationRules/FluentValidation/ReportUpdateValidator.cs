using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;
using Ysk.Todo.Dto.DTOs.ReportDto;

namespace Ysk.Todo.Business.ValidationRules.FluentValidation
{
    public class ReportUpdateValidator : AbstractValidator<ReportUpdateDto>
    {
        public ReportUpdateValidator()
        { 
            RuleFor(x => x.Description).NotNull().WithMessage("Tanım alanı boş geçilemez");
            RuleFor(x => x.Detail).NotNull().WithMessage("Detay alanı boş geçilemez");
        }
    }
}
