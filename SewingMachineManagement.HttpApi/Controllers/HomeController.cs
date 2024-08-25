using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SewingMachineManagement.HttpApi.Controllers;

[ApiController]
[Route("api/sewing/[controller]")]
[ApiExplorerSettings(GroupName = "SewingMachine")]
public class HomeController: ControllerBase
{
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public IActionResult Index()
    {
        return Ok("Hello World from SewingMachineManagement");
    }
}