using Microsoft.AspNetCore.Mvc;
using WarehouseClosingServer.Data;

namespace WarehouseClosingServer.Controllers;


[ApiController]
[Route("api/order")]
public class OrderController : Controller
{
    private readonly ApplicationDbContext _context;

    public OrderController(ApplicationDbContext context)
    {
        _context = context;
    }


    [HttpGet]
    public async Task<IActionResult> GetItem()
    {
        var сustomers = "I am order controller";
        return Ok(сustomers);
    }
}
