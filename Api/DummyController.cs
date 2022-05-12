using Microsoft.AspNetCore.Mvc;

namespace Api;

[ApiController]
[Route("[controller]")]
public class DummyController : ControllerBase
{
    private readonly IDummyHelper _dummyHelper;
    
    public DummyController(IDummyHelper dummyHelper)
    {
        _dummyHelper = dummyHelper;
    }

    [HttpGet(Name = "GetWeatherForecast")]
    public string Get() => _dummyHelper.CallDummyEndpoint("dummy");
}
