using Soenneker.Cursor.CloudAgents.HttpClients.Abstract;
using Soenneker.Tests.HostedUnit;

namespace Soenneker.Cursor.CloudAgents.HttpClients.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public sealed class CursorCloudAgentsOpenApiHttpClientTests : HostedUnitTest
{
    private readonly ICursorCloudAgentsOpenApiHttpClient _httpclient;

    public CursorCloudAgentsOpenApiHttpClientTests(Host host) : base(host)
    {
        _httpclient = Resolve<ICursorCloudAgentsOpenApiHttpClient>(true);
    }

    [Test]
    public void Default()
    {

    }
}
