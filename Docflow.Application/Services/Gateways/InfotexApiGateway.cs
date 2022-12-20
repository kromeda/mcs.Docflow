namespace Docflow.Application.Services.Gateways
{
    public class InfotexApiGateway : ApiGateway, IInfotextApiGateway
    {
        public InfotexApiGateway(HttpClient client) : base(client)
        {

        }
    }
}
