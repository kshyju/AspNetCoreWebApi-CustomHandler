using Microsoft.AspNetCore.Mvc;

namespace HelloWebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class FooController : ControllerBase
{
    private readonly ILogger<FooController> _logger;

    public FooController(ILogger<FooController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public string Get()
    {
        string buildConfig = string.Empty;

#if DEBUG
    buildConfig = "Debug build"; 
#else
    buildConfig = "Release build"; 
#endif

        return "FOO, from " + buildConfig;
    }
}
