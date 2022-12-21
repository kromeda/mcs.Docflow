namespace Docflow.Application.Interfaces
{
    public interface IEdoCommunicator
    {
        Task<Result<IEnumerable<Counterpart>>> GetCounterparts(CancellationToken ct);

        Task<Result<IEnumerable<FlowDocument>>> GetIncomeDocuments(CancellationToken ct);

        Task<Result<IEnumerable<FlowDocument>>> GetOutgoingDocuments(CancellationToken ct);

        Task<Result> PushDocument(FlowDocument document, CancellationToken ct);
    }
}
