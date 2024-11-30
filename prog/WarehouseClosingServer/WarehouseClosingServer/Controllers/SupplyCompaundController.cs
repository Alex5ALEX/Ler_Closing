using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WarehouseClosingServer.Data;
using WarehouseClosingServer.Models;

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
    public async Task<IActionResult> GetAllSupplyCompaund()
    {
        var compaunds = await _context.SupplyCompaunds.ToListAsync();
        return Ok(compaunds);
    }




    [HttpGet("{id_supply}")]
    public async Task<IActionResult> GetByIdSupply(Guid id_supply)
    {
        var compaund = await _context.SupplyCompaunds.Where(o => o.Id_Supply == id_supply).ToListAsync();

        if (compaund == null) { return NotFound(); }

        return Ok(compaund);
    }


    [HttpGet("{id_product}")]
    public async Task<IActionResult> GetByIdProducts(Guid id_product)
    {
        var compaund = await _context.SupplyCompaunds.Where(o => o.Id_Product == id_product).ToListAsync();

        if (compaund == null) { return NotFound(); }

        return Ok(compaund);
    }



    [HttpPost]
    public async Task<IActionResult> Set(
        [FromBody] SupplyCompaund compaund)
    {

        _context.SupplyCompaunds.Add(compaund);
        _context.SaveChanges();

        return Ok("Supply Compaund created");
    }




    [HttpPut("{id_supply}/{id_product}")]
    public async Task<IActionResult> Put(Guid id_supply, Guid id_product,
        [FromBody] SupplyCompaund compaundGet)
    {
        var compaund = _context.SupplyCompaunds.FirstOrDefault(c => c.Id_Supply == id_supply && c.Id_Product == id_product);

        if (compaund == null)
        {
            return NotFound();
        }


        compaund.Quantity = compaundGet.Quantity;
        compaund.Id_Supply = compaundGet.Id_Supply;
        compaund.Id_Product = compaundGet.Id_Product;

        _context.SaveChanges();

        return Ok("Supply Compaund updated");
    }



    [HttpDelete("{id_supply}/{id_product}")]
    public async Task<IActionResult> Delete(Guid id_supply, Guid id_product)
    {
        var compaund = _context.SupplyCompaunds.FirstOrDefault(c => c.Id_Supply == id_supply && c.Id_Product == id_product);

        if (compaund == null) { return NotFound(); }

        _context.SupplyCompaunds.Remove(compaund);
        _context.SaveChanges();

        return Ok("Supply Compaund deleted");
    }
}
