namespace Docflow.Application.Interfaces;

public interface IEdoCommunicator<TGateway> where TGateway : ApiGateway
{
    Task<Result<IEnumerable<FlowDocument>>> GetIncomeDocuments(CancellationToken ct);

    Task<Result<IEnumerable<FlowDocument>>> GetOutgoingDocuments(CancellationToken ct);

    Task<Result> PushDocument(FlowDocument document, CancellationToken ct);

    Task<Result<IEnumerable<Counterpart>>> GetCounterparts(CancellationToken ct);
}
