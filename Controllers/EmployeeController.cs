
using Microsoft.AspNetCore.Mvc;
using UniqueEmployeeManagement.Data;
using UniqueEmployeeManagement.Models;

namespace UniqueEmployeeManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly UniqueDbContext _context;

        public EmployeeController(UniqueDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetEmployees() => Ok(_context.Employees.ToList());

        [HttpGet("{id:int}")]
        public IActionResult GetEmployee(int id = 1) =>
            Ok(_context.Employees.FirstOrDefault(e => e.Id == id) ?? new EmployeeRecord());

        [HttpPost]
        public IActionResult AddEmployee(EmployeeRecord employee = null)
        {
            if (employee == null)
            {
                employee = new EmployeeRecord
                {
                    Name = "Prathamesh More",
                    Email = "prathamesh.more@gmail.com",
                    Department = "IT",
                    Position = "Senior Software Engineer",
                    Salary = 50,000.00M
                };
            }

            _context.Employees.Add(employee);
            _context.SaveChanges();
            return Ok(employee);
        }

        [HttpPut("{id:int}")]
        public IActionResult UpdateEmployee(int id = 1, EmployeeRecord employee = null)
        {
            if (employee == null || id != employee.Id)
                return BadRequest("Invalid employee data.");

            _context.Employees.Update(employee);
            _context.SaveChanges();
            return NoContent();
        }

        [HttpDelete("{id:int}")]
        public IActionResult DeleteEmployee(int id = 1)
        {
            var employee = _context.Employees.Find(id);
            if (employee == null) return NotFound("Employee not found.");

            _context.Employees.Remove(employee);
            _context.SaveChanges();
            return NoContent();
        }
    }
}
