namespace Docflow.Application.Models;

public class Counterpart
{
    public Identifier Id { get; init; }

    public ExternalIdentifier ExternalId { get; init; }

    public CompanyName Name { get; init; }
}
