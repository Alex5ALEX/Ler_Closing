using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WarehouseClosingServer.Data;
using WarehouseClosingServer.Models;

namespace WarehouseClosingServer.Controllers;


[ApiController]
[Route("api/employee")]
public class EmployeeController : Controller
{
    private readonly ApplicationDbContext _context;

    public EmployeeController(ApplicationDbContext context)
    {
        _context = context;
    }



    [HttpGet]
    public async Task<IActionResult> GetAllEmployee()
    {
        var сustomers = await _context.Employees.ToListAsync();
        return Ok(сustomers);
    }



    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(Guid id)
    {
        var employee = await _context.Employees.FindAsync(id);

        if (employee == null) { return NotFound(); }

        return Ok(employee);

    }


    [HttpPost]
    public async Task<IActionResult> Set(
        [FromBody] Employee employee)
    {
        employee.Id = new Guid();

        _context.Employees.Add(employee);
        _context.SaveChanges();

        return Ok("Employee created");
    }




    [HttpPut("{Id}")]
    public async Task<IActionResult> Put(
        Guid Id, [FromBody] Employee employeeGet)
    {
        var employee = _context.Employees.FirstOrDefault(c => c.Id == Id);

        if (employee == null)
        {
            return NotFound();
        }


        employee.Name = employeeGet.Name;
        employee.Surname = employeeGet.Surname;
        employee.JobTitle = employeeGet.JobTitle;
        employee.Phone = employeeGet.Phone;
        employee.Email = employeeGet.Email;
        employee.Address = employeeGet.Address;

        _context.SaveChanges();

        return Ok("Employee updated");
    }



    [HttpDelete("{Id}")]
    public async Task<IActionResult> Delete(Guid Id)
    {
        var employee = _context.Employees.FirstOrDefault(c => c.Id == Id);

        if (employee == null) { return NotFound(); }

        _context.Employees.Remove(employee);
        _context.SaveChanges();

        return Ok("Employee deleted");
    }



}
