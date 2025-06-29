using System.Collections;
using GovtVaccination.Data;
using GovtVaccination.Utilities;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;

namespace GovtVaccination.Controllers;

[Route("api/[controller]")]
public class RegistrationController : ControllerBase
{
    private readonly AppDbContext _context;
    public RegistrationController(AppDbContext context)
    {
        _context = context;
    }

    [HttpPost("register")]
    public async Task<IActionResult> Register()
    {
        // await _context.VaccineCenters.ToListAsync();
        var myStringList = new List<string>();
        myStringList.Add("Hello");
        myStringList.Add("World");  
        
        var responseFormatter =  new ResponseFormatter();
        var response = responseFormatter.SuccessResponse(myStringList);
        // ObjectPrinter.PrintProperties(response);
        return Ok(response);
    }
}