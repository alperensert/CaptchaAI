namespace CapSolver.Tests;

public class BaseMethodTests
{
    [Fact]
    public async Task TestBalance()
    {
        var client = new CapSolverClient(Environment.GetEnvironmentVariable("APIKEY")!, false);
        float balance = await client.GetBalance();
        Assert.IsType<float>(balance);
        Assert.True(default != balance);
    }

    [Fact]
    public async Task TestPackages()
    {
        var client = new CapSolverClient(Environment.GetEnvironmentVariable("APIKEY")!, false);
        List<string?> packages = await client.GetPackages();
        Assert.NotNull(packages);
        Assert.IsType<List<string?>>(packages);
    }
}