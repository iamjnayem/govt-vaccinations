using GovtVaccination.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace GovtVaccination.Controller;

using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using GovtVaccination.Data;

public class VaccinesController : ControllerBase
{
    private readonly AppDbContext _appDbContext;

    public VaccinesController(AppDbContext appDbContext)
    {
        _appDbContext = appDbContext;
    }

    [HttpGet]
    [Route("api/[controller]")]
    public async Task<IActionResult> Index()
    {
        return Ok("list");
    }

    [HttpPost]
    [Route("api/register")]
    public async Task<IActionResult> Register(VaccineRegistration request)
    {
        // var vaccineCenters = await _appDbContext.VaccineCenters.Where(v => v.Status == 1).ToListAsync();
        
        return Ok("fetched");
    }
}
