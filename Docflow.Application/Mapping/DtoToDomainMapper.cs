namespace Docflow.Application.Mapping;

public static class DtoToDomainMapper
{
    public static FlowDocument ToFlowDocument(this PushDocumentRequest request)
    => new FlowDocument
    {
        Id = request.Id,
        Name = request.Name,
        Data = request.Data
    };
}
