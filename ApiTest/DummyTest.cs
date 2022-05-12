using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.Extensions.DependencyInjection;
using System.Threading.Tasks;
using Api;
using Xunit;

namespace ApiTest;

public class DummyTest
{
    [Fact]
    public async Task NoMockTest()
    {
        // Arrange
        var application = new WebApplicationFactory<Program>()
            .WithWebHostBuilder(_ => { });

        var client = application.CreateClient();
        
        // Act
        var response = await client.GetAsync("/Dummy");
        
        // Assert
        var result = await response.Content.ReadAsStringAsync();
        Assert.Equal("dummy", result);
    }
    
    [Fact]
    public async Task MockTest()
    {
        // Arrange
        var application = new WebApplicationFactory<Program>()
            .WithWebHostBuilder(builder =>
            {
                builder.ConfigureServices(services =>
                {
                    services.AddScoped<IDummyHelper, TestDummyHelper>();
                });
            });

        var client = application.CreateClient();
        
        // Act
        var response = await client.GetAsync("/Dummy");
        
        // Assert
        var result = await response.Content.ReadAsStringAsync();
        Assert.Equal("notDummy", result);
    }
}
