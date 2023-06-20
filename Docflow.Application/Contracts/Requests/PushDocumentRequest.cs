using Docflow.Domain.Models.Enums;

namespace Docflow.Application.Contracts.Requests;

/// <summary>
/// Запрос на отправку файла
/// </summary>
public class PushDocumentRequest
{
    public int Id { get; init; }

    public string? Name { get; init; }

    public byte[]? Data { get; init; }

    public EdoType ProviderType { get; init; }
}
