namespace Docflow.Domain.Models.Common;

public class CompanyName : ValueOf<string, CompanyName>
{
    protected override void Validate()
    {
        if (string.IsNullOrEmpty(Value))
        {
            throw new ArgumentException("Отсутствует наименование", nameof(CompanyName));
        }
    }
}
