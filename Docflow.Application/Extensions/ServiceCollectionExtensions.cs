using Docflow.Application.Interfaces;
using Docflow.Application.Services.Communicators;

namespace Docflow.Application.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddGateways(this IServiceCollection services)
    {
        services.AddScoped<IDiadocApiGateway, DiadocApiGateway>();
        services.AddScoped<ISbisApiGateway, SbisApiGateway>();
        services.AddScoped<IInfotextApiGateway, InfotexApiGateway>();

        return services;
    }

    public static IServiceCollection AddCommunicators(this IServiceCollection services)
    {
        services.AddScoped<IEdoCommunicator, DiadocCommunicator>();
        services.AddScoped<IEdoCommunicator, SbisCommunicator>();
        services.AddScoped<IEdoCommunicator, InfotexCommunicator>();

        return services;
    }
}
