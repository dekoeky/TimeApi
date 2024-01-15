using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Filters;
using System.Globalization;
using TimeApi.Models;
using static TimeApi.Examples.TestControllerExamples;

namespace TimeApi.Controllers;

[ApiController]
[Route("[controller]")]
public class TestController : ControllerBase
{
    private readonly ILogger<TestController> _logger;

    public TestController(ILogger<TestController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    [SwaggerResponseExample(200, typeof(MyGoodExamples))]
    [SwaggerResponseExample(500, typeof(MyBadExample))]
    public TestData Get() => new()
    {
        Getal = DateTime.Now.Second,
        KommaGetal = DateTime.Now.Microsecond,
        Tekst = $"Het is " + DateTime.Today.Day.ToString(CultureInfo.GetCultureInfo("nl-BE")),
        Time = DateTime.Now,
    };
}
