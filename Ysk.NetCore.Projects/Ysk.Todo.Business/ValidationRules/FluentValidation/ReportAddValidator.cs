using FluentValidation;
using Ysk.Todo.Dto.DTOs.ReportDto;

namespace Ysk.Todo.Business.ValidationRules.FluentValidation
{
    public class ReportAddValidator : AbstractValidator<ReportAddDto>
    {
        public ReportAddValidator()
        { 
            RuleFor(x => x.Description).NotNull().WithMessage("Tanım alanı boş geçilemez");
            RuleFor(x => x.Detail).NotNull().WithMessage("Detay alanı boş geçilemez"); 
        }
    }
}
