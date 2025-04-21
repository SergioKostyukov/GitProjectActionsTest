using Microsoft.AspNetCore.Mvc;

namespace TempProj.WebAPI.Controllers;

[ApiController]
[Route("api/auth")]
public class AuthController : Controller
{
    [HttpGet("login")]
    public string Login() => "Logged in";
}
