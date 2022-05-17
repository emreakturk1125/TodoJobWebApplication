using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;
using Ysk.Todo.Dto.DTOs.TaskDto;

namespace Ysk.Todo.Business.ValidationRules.FluentValidation
{
    public class TaskUpdateValidator : AbstractValidator<TaskUpdateDto>
    {
        public TaskUpdateValidator()
        { 
            RuleFor(x => x.Name).NotNull().WithMessage("Ad adı boş geçilemez");
            RuleFor(x => x.UrgencyId).NotNull().WithMessage("Lütfen bir aciliyet durumu seçiniz");
        }
    }
}
