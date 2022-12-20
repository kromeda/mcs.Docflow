namespace Docflow.Domain.Models;

public class Counterpart
{
    public int Id { get; init; }

    public Guid ExternalId { get; init; }

    public string Name { get; init; }
}
