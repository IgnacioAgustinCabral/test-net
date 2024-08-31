using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TestController : ControllerBase
{
    [HttpGet("ok")]
    public IActionResult Test()
    {
        var response = new { message = "Hello World From Amazon" };
        return Ok(response);
    }
}