using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
namespace GovtVaccination.Controller;

public class VaccinesController : ControllerBase
{
    [HttpGet]
    [Route("api/[controller]")]
    public async Task<IActionResult> Index()
    {
        return Ok("list");
    }
}
