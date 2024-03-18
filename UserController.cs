using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

[Route("api/[controller]")]
[ApiController]
public class UserController : ControllerBase
{
    [HttpPost("register")]
    public async Task<IActionResult> Register(UserRegistrationModel model)
    {
        // Implement user registration logic
        return Ok();
    }

    [HttpPost("login")]
    public async Task<IActionResult> Login(UserLoginModel model)
    {
        // Implement user login logic
        return Ok();
    }
}
