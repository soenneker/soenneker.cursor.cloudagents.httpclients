using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Soenneker.Cursor.CloudAgents.HttpClients.Abstract;
using Soenneker.Utils.HttpClientCache.Registrar;

namespace Soenneker.Cursor.CloudAgents.HttpClients.Registrars;

/// <summary>
/// Registers the OpenAPI HttpClient wrapper for dependency injection.
/// </summary>
public static class CursorCloudAgentsOpenApiHttpClientRegistrar
{
    /// <summary>
    /// Adds <see cref="CursorCloudAgentsOpenApiHttpClient"/> as a singleton service. <para/>
    /// </summary>
    public static IServiceCollection AddCursorCloudAgentsOpenApiHttpClientAsSingleton(this IServiceCollection services)
    {
        services.AddHttpClientCacheAsSingleton()
                .TryAddSingleton<ICursorCloudAgentsOpenApiHttpClient, CursorCloudAgentsOpenApiHttpClient>();

        return services;
    }

    /// <summary>
    /// Adds <see cref="CursorCloudAgentsOpenApiHttpClient"/> as a scoped service. <para/>
    /// </summary>
    public static IServiceCollection AddCursorCloudAgentsOpenApiHttpClientAsScoped(this IServiceCollection services)
    {
        services.AddHttpClientCacheAsSingleton()
                .TryAddScoped<ICursorCloudAgentsOpenApiHttpClient, CursorCloudAgentsOpenApiHttpClient>();

        return services;
    }
}
