namespace Docflow.Application.Contracts.Requests;

/// <summary>
/// Запрос на отправку файла.
/// </summary>
public class PushDocumentRequest
{
    /// <summary>
    /// Идентификатор файла
    /// </summary>
    public int Id { get; init; }

    /// <summary>
    /// Наименование файла
    /// </summary>
    public string Name { get; init; }

    /// <summary>
    /// Байт массив файла
    /// </summary>
    public byte[] Data { get; init; }

    /// <summary>
    /// Провайдер, осуществляющий доставку файла
    /// </summary>
    public EdoType ProviderType { get; init; }
}
