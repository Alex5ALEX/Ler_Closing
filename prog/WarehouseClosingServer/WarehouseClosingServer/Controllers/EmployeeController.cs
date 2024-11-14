using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WarehouseClosingServer.Data;

namespace WarehouseClosingServer.Controllers;


[ApiController]
[Route("api/employee")]
public class EmployeeController : Controller
{
    private readonly ApplicationDbContext _context;

    public EmployeeController(ApplicationDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<IActionResult> GetItem()
    {
        var сustomers = "I am employee controller";
        return Ok(сustomers);
    }
}
