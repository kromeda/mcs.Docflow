namespace Docflow.Application.Models;

public class Counterpart
{
    public Identifier Id { get; private set; }

    public ExternalIdentifier ExternalId { get; private set; }

    public CompanyName Name { get; private set; }

    public Counterpart(Identifier id, ExternalIdentifier externalId, CompanyName name)
    {
        Id = id!;
        ExternalId = externalId!;
        Name = name!;
    }
}
