namespace Docflow.Application.Endpoints;

public class PushDocumentEndpoint : Endpoint<PushDocumentRequest, PushDocumentResponse>
{
    public IEnumerable<IEdoCommunicator> Communicators { get; set; }

    public override void Configure()
    {
        Post("send_document");
        AllowAnonymous();
    }

    public override async Task HandleAsync(PushDocumentRequest req, CancellationToken ct)
    {
        IEdoCommunicator communicator = Communicators.FindOfEnum(req.ProviderType);
        await communicator.PushDocument(req.ToFlowDocument(), ct);
    }
}
