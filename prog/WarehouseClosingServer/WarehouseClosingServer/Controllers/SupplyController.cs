using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WarehouseClosingServer.Data;
using WarehouseClosingServer.Models;

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
    public async Task<IActionResult> GetAllSupplies()
    {
        var supplys = await _context.Supplies.ToListAsync();
        return Ok(supplys);
    }




    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(Guid id)
    {
        var supply = await _context.Supplies.FindAsync(id);

        if (supply == null) { return NotFound(); }

        return Ok(supply);

    }


    [HttpPost]
    public async Task<IActionResult> Set(
        [FromBody] Supply supply)
    {
        supply.Id = new Guid();

        _context.Supplies.Add(supply);
        _context.SaveChanges();

        return Ok("Supply created");
    }




    [HttpPut("{Id}")]
    public async Task<IActionResult> Put(
        Guid Id, [FromBody] Supply supplyGet)
    {
        var supply = _context.Supplies.FirstOrDefault(c => c.Id == Id);

        if (supply == null)
        {
            return NotFound();
        }


        supply.Date = supplyGet.Date;
        supply.Price = supplyGet.Price;
        supply.Id_Provider = supplyGet.Id_Provider;

        _context.SaveChanges();

        return Ok("Supply updated");
    }



    [HttpDelete("{Id}")]
    public async Task<IActionResult> Delete(Guid Id)
    {
        var supply = _context.Supplies.FirstOrDefault(c => c.Id == Id);

        if (supply == null) { return NotFound(); }

        _context.Supplies.Remove(supply);
        _context.SaveChanges();

        return Ok("Supply deleted");
    }

}
