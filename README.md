[![](https://img.shields.io/nuget/v/soenneker.cursor.cloudagents.httpclients.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.cursor.cloudagents.httpclients/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.cursor.cloudagents.httpclients/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.cursor.cloudagents.httpclients/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.cursor.cloudagents.httpclients.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.cursor.cloudagents.httpclients/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.cursor.cloudagents.httpclients/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.cursor.cloudagents.httpclients/actions/workflows/codeql.yml)

# Soenneker.Cursor.CloudAgents.HttpClients

Provides a cached `HttpClient` configured for Cursor's Cloud Agents API with bearer authentication.

## Installation

```bash
dotnet add package Soenneker.Cursor.CloudAgents.HttpClients
```

## Configuration

```json
{
  "Cursor": {
    "ApiKey": "your-cursor-api-key"
  }
}
```

The default base address is `https://api.cursor.com/`, and requests send `Authorization: Bearer <ApiKey>`. Override these with `CloudAgents:ClientBaseUrl`, `CloudAgents:AuthHeaderName`, and `CloudAgents:AuthHeaderValueTemplate`; the value template uses `{token}` as the API-key placeholder.

## Registration and usage

```csharp
using Soenneker.Cursor.CloudAgents.HttpClients.Abstract;
using Soenneker.Cursor.CloudAgents.HttpClients.Registrars;

services.AddCursorCloudAgentsOpenApiHttpClientAsSingleton();

public sealed class CursorAccountReader(ICursorCloudAgentsOpenApiHttpClient clients)
{
    public async Task<HttpResponseMessage> Get(CancellationToken cancellationToken)
    {
        HttpClient client = await clients.Get(cancellationToken);
        return await client.GetAsync("v1/me", cancellationToken);
    }
}
```

`Get` returns the same cached client for the provider's lifetime. The provider owns it, so callers should dispose response messages but not the returned `HttpClient`. Prefer the singleton registration for normal application use; the scoped registration creates a separately owned cache entry for each scope.
