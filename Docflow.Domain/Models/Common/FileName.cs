namespace Docflow.Domain.Models.Common;

public class FileName : ValueOf<string, FileName>
{
    protected override void Validate()
    {
        IEnumerable<ValidationFailure> failures = FindFailures(Value);

        if (failures.Any())
        {
            const string message = "Имя файла содержит ошибки";
            throw new ValidationException(message, failures);
        }
    }

    private IEnumerable<ValidationFailure> FindFailures(string value)
    {
        if (value.IndexOfAny(Path.GetInvalidFileNameChars()) != -1)
        {
            const string message = "Имя файла содержит недопустимые символы";
            yield return new ValidationFailure(nameof(FileContentData), message);
        }

        if (value.Length >= 256)
        {
            const string message = "Длинна имени файла превышает допустимный лимит в 256 символов";
            yield return new ValidationFailure(nameof(FileContentData), message);
        }
    }
}
