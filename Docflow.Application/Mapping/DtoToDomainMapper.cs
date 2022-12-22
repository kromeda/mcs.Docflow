namespace Docflow.Application.Mapping;

public static class DtoToDomainMapper
{
    public static FlowDocument ToFlowDocument(this PushDocumentRequest request)
        => new FlowDocument
        {
            Id = Identifier.From(request.Id),
            Name = FileName.From(request.Name),
            Data = FileContentData.From(request.Data)
        };
}
