using Microsoft.AspNetCore.Mvc;

namespace TempProj.WebAPI.Controllers;

[ApiController]
[Route("api/test")]
public class TestController : ControllerBase
{
    private ILogger<TestController> logger;

    public TestController(ILogger<TestController> logger)
    {
        this.logger = logger;
    }

    [HttpGet]
    public async Task<IActionResult> GetData()
    {
        logger.LogInformation("here");

        var x = 5;
        var y = 10;
        var result = x + y;

        return Ok();
    }
}