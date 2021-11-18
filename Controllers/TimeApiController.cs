using Microsoft.AspNetCore.Mvc;

namespace HelloWebApi.Controllers;

[ApiController]
public class TimeApiController : ControllerBase
{
    private readonly ILogger<TimeApiController> _logger;

    public TimeApiController(ILogger<TimeApiController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    [Route("api/time")]
    public IEnumerable<string> Get()
    {
        return new string[] {$"Current UTC time is {System.DateTime.UtcNow}"};
    }
}
