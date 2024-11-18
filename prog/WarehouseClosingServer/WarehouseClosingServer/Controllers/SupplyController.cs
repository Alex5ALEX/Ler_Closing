using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WarehouseClosingServer.Data;

namespace WarehouseClosingServer.Controllers;


[ApiController]
[Route("api/supply")]
public class SupplyController : Controller
{
    private readonly ApplicationDbContext _context;

    public SupplyController(ApplicationDbContext context)
    {
        _context = context;
    }



    [HttpGet]
    public async Task<IActionResult> GetAllProducts()
    {
        var supplies = await _context.Supplies.ToListAsync();
        return Ok(supplies);
    }

}
