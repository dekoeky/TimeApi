using Microsoft.AspNetCore.Mvc;

//TODO: File Scoped Namespace
namespace TimeApi.Controllers;

[ApiController]
[Route("[controller]")]
public class TimeController : ControllerBase
{
    private readonly ILogger<TimeController> _logger;

    public TimeController(ILogger<TimeController> logger)
    {
        _logger = logger;
    }

    [HttpGet("Local", Name = nameof(GetLocalTime))]
    public DateTime GetLocalTime() => DateTime.Now;

    [HttpGet("Utc", Name = nameof(GetUtcTime))]
    public DateTime GetUtcTime() => DateTime.UtcNow;

    [HttpGet("", Name = nameof(GetTime))]
    public IActionResult GetTime() => Redirect(Request.Path + "/Local");

    //TODO: TimeZone Info
    //TODO: DateTimeOffset
    //TODO: DateOnly
    //TODO: TimeOnly
}