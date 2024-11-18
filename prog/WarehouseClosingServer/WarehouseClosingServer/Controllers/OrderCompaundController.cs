using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
    public async Task<IActionResult> GetAllProducts()
    {
        var orederCompaund = await _context.OrderCompaunds.ToListAsync();
        return Ok(orederCompaund);
    }
}
