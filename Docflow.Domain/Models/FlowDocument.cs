namespace Docflow.Application.Models;

public class FlowDocument
{
    public Identifier Id { get; init; }

    public ExternalIdentifier ExternalId { get; init; }

    public FileContentData Data { get; init; }

    public FileName Name { get; init; }
}