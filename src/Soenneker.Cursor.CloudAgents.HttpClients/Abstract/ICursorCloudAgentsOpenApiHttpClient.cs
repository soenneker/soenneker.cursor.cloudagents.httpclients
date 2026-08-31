using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Threading;

namespace Soenneker.Cursor.CloudAgents.HttpClients.Abstract;

/// <summary>
/// Provides a cached, authenticated <see cref="HttpClient"/> for Cursor's Cloud Agents API.
/// </summary>
public interface ICursorCloudAgentsOpenApiHttpClient: IDisposable, IAsyncDisposable
{
    /// <summary>
    /// Gets the client owned by this provider.
    /// </summary>
    /// <param name="cancellationToken">The cancellation token.</param>
    /// <returns>The configured Cursor client.</returns>
    ValueTask<HttpClient> Get(CancellationToken cancellationToken = default);
}
