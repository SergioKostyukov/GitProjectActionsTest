using Microsoft.AspNetCore.Mvc;

namespace TempProj.WebAPI.Controllers;

[ApiController]
[Route("api/test")]
public class TestController(ILogger<TestController> logger) : ControllerBase
{
    private readonly ILogger<TestController> _logger = logger;

    [HttpGet("get/data")]
    public async Task<IActionResult> GetSomeData()
    {
        _logger.LogInformation("GetSomeData method is active!)");

        return Ok();
    }
}
