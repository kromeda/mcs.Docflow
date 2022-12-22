namespace Docflow.Domain.Models.Common;

public class Identifier : ValueOf<int, Identifier>
{
    protected override void Validate()
    {
        if (Value < 0)
        {
            const string message = "Идентификатор должен быть положительным числом";
            throw new ValidationException(message, new[]
            {
                new ValidationFailure(nameof(Identifier), message)
            });
        }
    }
}
