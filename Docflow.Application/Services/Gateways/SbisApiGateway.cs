namespace Docflow.Application.Services.Gateways;

public sealed class SbisApiGateway : ApiGateway, ISbisApiGateway
{
    public SbisApiGateway(HttpClient client) : base(client)
    {

    }
}
