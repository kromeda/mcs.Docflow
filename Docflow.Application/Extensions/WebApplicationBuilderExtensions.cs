namespace Docflow.Application.Extensions;

internal static class WebApplicationBuilderExtensions
{
    public static void AddFlowOptions(this WebApplicationBuilder builder)
    { 
        builder.Services.AddOptions();
        builder.Configuration.AddJsonFile($"appsettings.{Utility.CurrentEnvironment}.json");
        builder.Services.Configure<DiadocGatewayOptions>(builder.Configuration.GetSection(nameof(DiadocGatewayOptions)));
    }
}
