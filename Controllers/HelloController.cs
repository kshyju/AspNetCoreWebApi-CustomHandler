using Microsoft.AspNetCore.Mvc;

namespace HelloWebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class HelloController : ControllerBase
{
    private readonly ILogger<HelloController> _logger;

    public HelloController(ILogger<HelloController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public IEnumerable<string> Get()
    {
        return new string[] {"Hello","Bonjour","Ciao"};
    }
}
