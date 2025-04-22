using Microsoft.AspNetCore.Mvc;

namespace TempProj.WebAPI.Controllers;

/// <summary>
/// ��������� ��� �������� ������.
/// </summary>
[ApiController]
[Route("api/test")]
public class TestController(ILogger<TestController> logger) : ControllerBase
{
    private readonly ILogger<TestController> _logger = logger;

    /// <summary>
    /// �������� ������ ���.
    /// </summary>
    [HttpGet("get/data")]
    public async Task<IActionResult> GetDataAsync()
    {
        const int firstValue = 5;
        const int secondValue = 10;
        var result = firstValue + secondValue;

        _logger.LogInformation("�������� ������ ���. ���������: {Result}", result);

        return Ok(result);
    }
}
