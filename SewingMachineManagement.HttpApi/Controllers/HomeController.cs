using Microsoft.AspNetCore.Mvc;

namespace SewingMachineManagement.HttpApi.Controllers;

[ApiController]
[Route("api/sewing/[controller]")]
[ApiExplorerSettings(GroupName = "SewingMachine")]
public class HomeController: ControllerBase
{
    [HttpGet]
    public IActionResult Index()
    {
        return Ok("Hello World from SewingMachineManagement");
    }
}