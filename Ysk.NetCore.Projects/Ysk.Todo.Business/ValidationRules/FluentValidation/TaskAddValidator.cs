using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;
using Ysk.Todo.Dto.DTOs.TaskDto;

namespace Ysk.Todo.Business.ValidationRules.FluentValidation
{
    public class TaskAddValidator : AbstractValidator<TaskAddDto>
    {
        public TaskAddValidator()
        {

            RuleFor(x => x.Name).NotNull().WithMessage("Ad alanı boş geçilemez");
            RuleFor(x => x.Description).NotNull().WithMessage("Tanım alanı boş geçilemez");
            RuleFor(x => x.UrgencyId).NotNull().WithMessage("Lütfen bir aciliyet durumu seçiniz");
        }
    }
}
