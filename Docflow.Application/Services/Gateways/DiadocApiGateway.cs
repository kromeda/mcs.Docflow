using Diadoc.Api;
using Diadoc.Api.Cryptography;
using Diadoc.Api.Proto.Events;

namespace Docflow.Application.Services.Gateways;

internal sealed class DiadocApiGateway : IDiadocApiGateway
{
    private DiadocApi? _api;
    private DiadocGatewayOptions? _options;

    public DiadocApiGateway(IOptionsMonitor<DiadocGatewayOptions> options)
    {
        OptionsUpdate(options.CurrentValue);
        options.OnChange(OptionsUpdate);
    }

    public async Task<Message> PushMessage(MessageToPost message, CancellationToken ct)
    {
        ct.ThrowIfCancellationRequested();

        string authToken = _api!.Authenticate(_options!.DefaultLogin, _options.DefaultPassword);
        Message response = await _api.PostMessageAsync(authToken, message);

        return response;
    }
    
    private void OptionsUpdate(DiadocGatewayOptions options)
    {
        _api = new DiadocApi(options.DefaultClientId, options.DefaultApiUrl, new WinApiCrypt());
        _options = options;
    }
}
