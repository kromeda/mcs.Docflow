namespace Docflow.Application.Contracts.Response;

public class ValidationFailureResponse
{
    public List<string> Errors { get; init; } = new();
}
