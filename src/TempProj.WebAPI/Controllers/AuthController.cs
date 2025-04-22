using Microsoft.AspNetCore.Mvc;

namespace TempProj.WebAPI.Controllers;

/// <summary>
/// Контролер для авторизації та аутентифікацї.
/// </summary>
[ApiController]
[Route("api/auth")]
public class AuthController : Controller
{
    /// <summary>
    /// Обробка авторизації користувача.
    /// </summary>
    [HttpGet("login")]
    public async Task<IActionResult> Login()
    {
        try
        {
            // ! тут асинзхронний запит до сервісу для виконання авторизації !

            return Ok();
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
}
