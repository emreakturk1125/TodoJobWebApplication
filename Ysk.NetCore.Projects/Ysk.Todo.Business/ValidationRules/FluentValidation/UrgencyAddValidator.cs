using FluentValidation;
using Ysk.Todo.Dto.DTOs.UrgencyDto;

namespace Ysk.Todo.Business.ValidationRules.FluentValidation
{
    public class UrgencyAddValidator : AbstractValidator<UrgencyAddDto>
    {
        public UrgencyAddValidator()
        {
            RuleFor(x => x.Description).NotNull().WithMessage("Tanım alanı boş geçilemez");
        }
    }
}
