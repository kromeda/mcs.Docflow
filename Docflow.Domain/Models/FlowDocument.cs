namespace Docflow.Application.Models;

public class FlowDocument
{
    public int Id { get; init; }

    public Guid ExternalId { get; init; }

    public byte[] Data { get; init; }

    public string Name { get; init; }
}