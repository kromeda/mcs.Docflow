namespace Docflow.Application.Models;

public class FlowDocument
{
    public Identifier Id { get; private set; }

    public ExternalIdentifier? ExternalId { get; private set; }

    public FileContentData Data { get; private set; }

    public FileName Name { get; private set; }

    public FlowDocument(Identifier id, FileContentData data, FileName name)
    {
        Id = id!;
        Data = data!;
        Name = name!;
    }

    public void ChangeExternalId(ExternalIdentifier externalId)
    {
        ExternalId = externalId!;
    }
}