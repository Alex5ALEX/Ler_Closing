using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WarehouseClosingServer.Data;
using WarehouseClosingServer.Models;

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
    public async Task<IActionResult> GetAllProducts()
    {
        var providers = await _context.Providers.ToListAsync();
        return Ok(providers);
    }
}
