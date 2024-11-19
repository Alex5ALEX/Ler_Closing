using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WarehouseClosingServer.Data;
using WarehouseClosingServer.Models;

using WarehouseClosingServer.Controllers.PoostModels;

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


    [HttpGet("{Id}")]
    public async Task<IActionResult> GetById(Guid Id)
    {
        var customer = _context.Customers.FirstOrDefault(c => c.Id == Id);

        if (customer == null)
        {
            return NotFound(); // Возвращает 404, если клиент не найден
        }


        //_context.SaveChanges();

        return Ok(customer);

    }


    [HttpPost]
    public async Task<IActionResult> Set(
        [FromBody] PostCustomer customer)
    {
        var newCustomer = new Customer()
        {
            Name = customer.Name,
            Surname = customer.Surname,
            Phone = customer.Phone,
            Email = customer.Email,
            Address = customer.Address
        };

        _context.Customers.Add(newCustomer);
        _context.SaveChanges();

        return Ok("Customer created");
    }

    [HttpPut("{Id}")]
    public async Task<IActionResult> Put(
        Guid Id, [FromBody] PostCustomer customerGet)
    {
        var customer = _context.Customers.FirstOrDefault(c => c.Id == Id);
        
        if (customer == null){
            return NotFound();
        }


        customer.Name = customerGet.Name;
        customer.Surname = customerGet.Surname;
        customer.Phone = customerGet.Phone;
        customer.Email = customerGet.Email;
        customer.Address = customerGet.Address;

        _context.SaveChanges();

        return Ok("Customer updated");
    }



    [HttpDelete("{Id}")]
    public async Task<IActionResult> Delete(Guid Id)
    {

        var customer = _context.Customers.FirstOrDefault(c => c.Id == Id);


        if (customer == null)
        {
            return NotFound();
        }

        _context.Customers.Remove(customer);

        _context.SaveChanges();
        
        return Ok("Customer deleted");
    }



}
