using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PrintingFactoryManagement.HttpApi.Controllers;

[ApiController]
[Route("api/printing/[controller]")]
[ApiExplorerSettings(GroupName = "PrintingFactory")]
public class HomeController: ControllerBase
{
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public IActionResult Index()
    {
        return Ok("Hello World");
    }
}