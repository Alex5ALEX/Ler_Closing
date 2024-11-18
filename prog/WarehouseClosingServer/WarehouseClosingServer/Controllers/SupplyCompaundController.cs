using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WarehouseClosingServer.Data;

namespace WarehouseClosingServer.Controllers;



[ApiController]
[Route("api/supply_compaund")]
public class SupplyCompaundController : Controller
{
    private readonly ApplicationDbContext _context;

    public SupplyCompaundController(ApplicationDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<IActionResult> GetAllProducts()
    {
        var supplyCompaunds = await _context.SupplyCompaunds.ToListAsync();
        return Ok(supplyCompaunds);
    }
}
