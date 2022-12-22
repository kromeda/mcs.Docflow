using FluentValidation;

namespace Docflow.Application.Validation
{
    public class PushDocumentRequestValidator : AbstractValidator<PushDocumentRequest>
    {
        public PushDocumentRequestValidator()
        {
            RuleFor(x => x.Id)
                .GreaterThan(0)
                .WithMessage("Идентификатор должен быть положительным числом");

            RuleFor(x => x.Name)
                .NotEmpty()
                .NotNull()
                .WithMessage("Отсутствует имя файла");

            RuleFor(x => x.Data)
                .NotNull()
                .Must(x => x.Length > 0)
                .WithMessage("Отсутствует содержимое файла");
        }
    }
}
