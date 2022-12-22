namespace Docflow.Application.Endpoints;

public class PushDocumentEndpoint : Endpoint<PushDocumentRequest, PushDocumentResponse>
{
    public IEnumerable<IEdoCommunicator> Communicators { get; init; }

    public override void Configure()
    {
        Post("send_document");
        AllowAnonymous();
        Validator<PushDocumentRequestValidator>();
    }

    public override async Task HandleAsync(PushDocumentRequest req, CancellationToken ct)
    {
        IEdoCommunicator communicator = Communicators.FindOfEnum(req.ProviderType);
        FlowDocument document = req.ToFlowDocument();
        await communicator.PushDocument(document, ct);
        await SendOkAsync(document.ToPushDocument(), ct);
    }
}
