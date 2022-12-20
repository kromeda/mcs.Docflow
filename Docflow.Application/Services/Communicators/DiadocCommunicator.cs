using Diadoc.Api.Proto.Events;

namespace Docflow.Application.Services.Communicators;

public class DiadocCommunicator<T> : IEdoCommunicator<T>
    where T : ApiGateway, IDiadocApiGateway
{
    private T _apiGateway;

    public DiadocCommunicator(T gateway)
    {
        _apiGateway = gateway; 
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

    public async Task<Result> PushDocument(FlowDocument document, CancellationToken _)
    {
        await _apiGateway.PushMessage(new MessageToPost());
        return Result.Success();
    }
}