using EmployeeCRUD.DbCon;
using EmployeeCRUD.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EmployeeCRUD.Controllers;

[Route("api/[controller]")]
[ApiController]
public class EmployeeController : ControllerBase
{
    private readonly DbConContext _dbContext;
    public EmployeeController(DbConContext dbContext)
    {
        _dbContext = dbContext;
    }
    //API02
    [HttpGet]
    public async Task<ActionResult<TblEmplyee>> GetEmployee()
    {
        var result = _dbContext.TblEmplyees.OrderByDescending(e => e.EmployeeSalary).Skip(2).First();
        return result;

    }

    [HttpGet("{id}")]
    public async Task<ActionResult<TblEmplyee>> GetEmployee(int id)
    {

        var employee = await _dbContext.TblEmplyees.FindAsync(id);
        return employee;


    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateEmployee(int id, TblEmplyee tblEmployee)
    {

        if (id != tblEmployee.EmployeeId)
        {
            return BadRequest();
        }
        // API01 Problem solution
        _dbContext.Entry(tblEmployee).State = EntityState.Modified;
        _dbContext.Entry(tblEmployee).Property("EmployeeSalary").IsModified = false;
        _dbContext.Entry(tblEmployee).Property("SupervisorId").IsModified = false;

        try
        {
            await _dbContext.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!EmployeeExists(id))
            {
                return NotFound();
            }
            else
            {
                throw;
            }
        }

        return NoContent();
    }
    private bool EmployeeExists(int id)
    {
        return (_dbContext.TblEmplyees?.Any(e => e.EmployeeId == id)).GetValueOrDefault();
    }
}
