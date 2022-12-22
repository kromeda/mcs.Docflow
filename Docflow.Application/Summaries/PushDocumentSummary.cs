namespace Docflow.Application.Summaries;

public class PushDocumentSummary : Summary<PushDocumentEndpoint>
{
    public PushDocumentSummary()
    {
        Summary = "Передает документ провайдеру ЭДО";
        Description = "Передает документ провайдеру ЭДО";
        Response<PushDocumentResponse>(200, 
            @"Документ успешно зарегистрирован у провайдера ЭДО. 
            Содержит уникальный идентификатор для запроса информации по переданному документу.");
        ExampleRequest = new PushDocumentRequest
        {
            Id = 1,
            Data = new byte[] { 0, 2, 64 },
            Name = "file_under_test.xlsx",
            ProviderType = EdoType.Diadoc
        };
    }
}
