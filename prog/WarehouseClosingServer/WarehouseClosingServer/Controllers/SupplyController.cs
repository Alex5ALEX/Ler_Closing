using Microsoft.AspNetCore.Mvc;
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
    public async Task<IActionResult> GetItem()
    {
        var сustomers = "I am supply controller";
        return Ok(сustomers);
    }

}
