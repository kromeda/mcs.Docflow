namespace Docflow.Domain.Models.Common;

public class FileContentData : ValueOf<byte[], FileContentData>
{
    protected override void Validate()
    {
        if (Value == null || Value.Length == 0)
        {
            const string message = "Отсутствует содержимое файла";
            throw new ValidationException(message, new[]
            {
                new ValidationFailure(nameof(FileContentData), message)
            });
        }
    }
}
