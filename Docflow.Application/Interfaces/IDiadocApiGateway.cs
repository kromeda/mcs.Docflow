using Diadoc.Api.Proto.Events;

namespace Docflow.Application.Interfaces;

public interface IDiadocApiGateway
{
    Task<Message> PushMessage(MessageToPost message, CancellationToken ct);
}