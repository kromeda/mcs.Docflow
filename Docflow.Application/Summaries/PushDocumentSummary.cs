namespace Docflow.Application.Summaries;

public class PushDocumentSummary : Summary<PushDocumentEndpoint, PushDocumentRequest>
{
    public PushDocumentSummary()
    {
        Summary = "Передает документ провайдеру ЭДО";
        Description = "Передает документ провайдеру ЭДО";
        Request();
        Response();
    }

    private void Request()
    {
        RequestParam(r => r.Id, "Идентификатор файла");
        RequestParam(r => r.Name, "Наименование файла");
        RequestParam(r => r.Data, "Байт массив файла");
        RequestParam(r => r.ProviderType, "Провайдер, осуществляющий доставку файла");

        ExampleRequest = new PushDocumentRequest
        {
            Id = 1,
            Data = new byte[] { 0, 2, 64 },
            Name = "file_under_test.xlsx",
            ProviderType = EdoType.Diadoc
        };
    }

    private void Response()
    {
        ResponseParam<PushDocumentResponse>(r => r.ExternalId, "Идентификатор документа в системе ЭДО");
        Response(200,
            "Документ успешно зарегистрирован у провайдера ЭДО. Содержит уникальный идентификатор для запроса информации по переданному документу.",
            example: new PushDocumentResponse
            {
                ExternalId = "18d0020d-62f0-4ec5-b0f9-a95aaa60b852"
            });
    }
}
