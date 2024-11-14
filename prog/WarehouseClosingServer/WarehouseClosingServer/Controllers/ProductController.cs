using Microsoft.AspNetCore.Mvc;
using WarehouseClosingServer.Data;

namespace WarehouseClosingServer.Controllers;


[ApiController]
[Route("api/product")]
public class ProductController : Controller
{
    private readonly ApplicationDbContext _context;

    public ProductController(ApplicationDbContext context)
    {
        _context = context;
    }


    [HttpGet]
    public async Task<IActionResult> GetItem()
    {
        var сustomers = "I am product controller";
        return Ok(сustomers);
    }
}
