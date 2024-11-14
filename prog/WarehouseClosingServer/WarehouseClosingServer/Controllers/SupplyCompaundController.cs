using Microsoft.AspNetCore.Mvc;
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
    public async Task<IActionResult> GetItem()
    {
        var сustomers = "I am supply_compaund controller";
        return Ok(сustomers);
    }
}
