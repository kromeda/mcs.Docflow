namespace Docflow.Application.Mapping;

public static class DtoToDomainMapper
{
    public static FlowDocument ToFlowDocument(this PushDocumentRequest request)
        => new FlowDocument(Identifier.From(request.Id), FileContentData.From(request.Data!), FileName.From(request.Name!));
}
