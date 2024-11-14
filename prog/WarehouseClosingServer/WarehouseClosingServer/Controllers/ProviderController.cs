using Microsoft.AspNetCore.Mvc;
using WarehouseClosingServer.Data;

namespace WarehouseClosingServer.Controllers;


[ApiController]
[Route("api/provider")]
public class ProviderController : Controller
{
    private readonly ApplicationDbContext _context;

    public ProviderController(ApplicationDbContext context)
    {
        _context = context;
    }


    [HttpGet]
    public async Task<IActionResult> GetItem()
    {
        var сustomers = "I am provider controller";
        return Ok(сustomers);
    }
}
