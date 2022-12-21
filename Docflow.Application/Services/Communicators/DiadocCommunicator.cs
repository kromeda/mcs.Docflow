using Diadoc.Api.Proto.Events;

namespace Docflow.Application.Services.Communicators;

public class DiadocCommunicator
{
    private readonly IDiadocApiGateway _api;

    public DiadocCommunicator(IDiadocApiGateway gateway)
    {
        _api = gateway; 
    }

    public Task<Result<IEnumerable<Counterpart>>> GetCounterparts(CancellationToken ct)
    {
        throw new NotImplementedException();
    }

    public Task<Result<IEnumerable<FlowDocument>>> GetIncomeDocuments(CancellationToken ct)
    {
        throw new NotImplementedException();
    }

    public Task<Result<IEnumerable<FlowDocument>>> GetOutgoingDocuments(CancellationToken ct)
    {
        throw new NotImplementedException();
    }

    public async Task<Result> PushDocument(FlowDocument document, CancellationToken ct)
    {
        MessageToPost message = new MessageToPost
        {
            FromDepartmentId = document.ExternalId.ToString()
        };

        await _api.PushMessage(message, ct);
        return Result.Success();
    }
}