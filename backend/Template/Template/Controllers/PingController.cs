using Microsoft.AspNetCore.Mvc;

namespace Template.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PingController : ControllerBase
{
    public PingController()
    {
    }

    [HttpGet("/ping")]
    public ActionResult<byte[]?> GeneratePdf()
    {
        return Ok("pong");
    }
}