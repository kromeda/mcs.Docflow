namespace Docflow.Domain.Models.Common;

public class ExternalIdentifier : ValueOf<Guid, ExternalIdentifier>
{
    protected override void Validate()
    {
        if (Value == Guid.Empty)
        {
            throw new ArgumentException("Внешний идентификатор не может быть пуст", nameof(ExternalIdentifier));
        }
    }
}
