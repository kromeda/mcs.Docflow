using Microsoft.AspNetCore.Authorization;

namespace Docflow.Application.Endpoints;

[HttpPost("send_document"), AllowAnonymous]
public class PushDocumentEndpoint : Endpoint<PushDocumentRequest, PushDocumentResponse>
{
    public IEnumerable<IEdoCommunicator> Communicators { get; init; }

    public override async Task HandleAsync(PushDocumentRequest req, CancellationToken ct)
    {
        IEdoCommunicator communicator = Communicators.FindOfEnum(req.ProviderType);
        FlowDocument document = req.ToFlowDocument();
        await communicator.PushDocument(document, ct);
        await SendOkAsync(document.ToPushDocument(), ct);
    }
}
