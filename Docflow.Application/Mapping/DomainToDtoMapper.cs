namespace Docflow.Application.Mapping;

public static class DomainToDtoMapper
{
    public static PushDocumentResponse ToPushDocument(this FlowDocument flowDocument)
        => new PushDocumentResponse
        {
            ExternalId = flowDocument.ExternalId.ToString()
        };
}
