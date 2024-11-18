using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WarehouseClosingServer.Data;
using WarehouseClosingServer.Models;

namespace WarehouseClosingServer.Controllers;


[ApiController]
[Route("api/customer")]
public class CustomersController : Controller
{

    
    private readonly ApplicationDbContext _context;

    public CustomersController(ApplicationDbContext context)
    {
        _context = context;
    }


    [HttpGet]
    public async Task<IActionResult> GetAllProducts()
    {
        var сustomers = await _context.Customers.ToListAsync();
        return Ok(сustomers);
    }


    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(string Id)
    {
        var customer = await _context.Customers.FindAsync(Guid.Parse(Id));

        if (customer == null)
        {
            return NotFound(); // Возвращает 404, если клиент не найден
        }

        return Ok(customer);
    }


    [HttpPost]
    public async Task<IActionResult> Set(
        string Name,
        string Surname,
        string Phone,
        string Email,
        string Address)
    {
         var newCustomer = new Customer()
        {
            Name = Name,
            Surname = Surname,
            Phone = Phone,
            Email = Email,
            Address = Address
        };

        _context.Customers.Add(newCustomer);
        _context.SaveChanges();

        return Ok("Customer created");
    }


    

}
