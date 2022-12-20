namespace Docflow.Domain.Models;

public class FlowDocument
{
    public int Id { get; init; }

    public Guid ExternalId { get; init; }

    public string Name { get; init; }
}