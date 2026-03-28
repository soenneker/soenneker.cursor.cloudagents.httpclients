using Soenneker.Cursor.CloudAgents.HttpClients.Abstract;
using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.Cursor.CloudAgents.HttpClients.Tests;

[Collection("Collection")]
public sealed class CursorCloudAgentsOpenApiHttpClientTests : FixturedUnitTest
{
    private readonly ICursorCloudAgentsOpenApiHttpClient _httpclient;

    public CursorCloudAgentsOpenApiHttpClientTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
        _httpclient = Resolve<ICursorCloudAgentsOpenApiHttpClient>(true);
    }

    [Fact]
    public void Default()
    {

    }
}
