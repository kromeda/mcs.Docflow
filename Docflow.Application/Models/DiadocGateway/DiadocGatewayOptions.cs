namespace Docflow.Application.Models.DiadocGateway;

public class DiadocGatewayOptions
{
    public string DefaultApiUrl { get; init; }

    public string DefaultClientId { get; init; }

    public string DefaultLogin { get; init; }

    public string DefaultPassword { get; init; }

    public string DefaultFromBoxId { get; init; }

    public string DefaultToBoxId { get; init; }

    public string CertificatePath { get; init; } // TODO: поменять на серийный номер сертификата в mmc
}
