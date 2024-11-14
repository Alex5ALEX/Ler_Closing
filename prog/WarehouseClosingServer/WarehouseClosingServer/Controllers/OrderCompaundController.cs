using Microsoft.AspNetCore.Mvc;
using WarehouseClosingServer.Data;

namespace WarehouseClosingServer.Controllers;

[ApiController]
[Route("api/order_compaund")]
public class OrderCompaundController : Controller
{
    private readonly ApplicationDbContext _context;

    public OrderCompaundController(ApplicationDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<IActionResult> GetItem()
    {
        var сustomers = "I am order_compaund controller";
        return Ok(сustomers);
    }
}
