namespace Docflow.Application.Services.Communicators;

public class InfotexCommunicator : IEdoCommunicator
{
    private readonly IInfotextApiGateway _api;

    public InfotexCommunicator(IInfotextApiGateway gateway)
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

    public Task<Result> PushDocument(FlowDocument document, CancellationToken ct)
    {
        throw new NotImplementedException();
    }
}
