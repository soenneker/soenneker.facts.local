using Xunit;

namespace Soenneker.Facts.Local.Tests;

public class LocalFactTests
{
    [Fact]
    public void Default()
    {
        Assert.True(true);
    }

    [LocalFact]
    public void Local_should_skip_environment()
    {
        Assert.True(true);
    }
}