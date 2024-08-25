using Microsoft.AspNetCore.Mvc;

namespace PrintingFactoryManagement.HttpApi.Controllers;

[ApiController]
[Route("api/printing/[controller]")]
public class HomeController: ControllerBase
{
    [HttpGet]
    public IActionResult Index()
    {
        return Ok("Hello World");
    }
}