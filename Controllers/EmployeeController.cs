using Microsoft.AspNetCore.Mvc;
using MyAsp.netWebAPI.Data;
using MyAsp.netWebAPI.Models;

namespace MyAsp.netWebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : ControllerBase
    {
        private readonly AppDbContext _context;

        public EmployeeController(AppDbContext context)
        {
            _context = context;
        }

        // POST: api/Employee
        [HttpPost]
        public IActionResult AddEmployee([FromBody] Employee employee)
        {
            _context.Employees.Add(employee);
            _context.SaveChanges();
            return Ok(employee);
        }

        // GET: api/Employee
        [HttpGet]
        public IActionResult GetAllEmployees()
        {
            var employees = _context.Employees.ToList();
            return Ok(employees);
        }

        // GET: api/Employee/5
        [HttpGet("{id}")]
        public IActionResult GetEmployeeById(int id)
        {
            var employee = _context.Employees.Find(id);
            if (employee == null)
                return NotFound();
            return Ok(employee);
        }

        // PUT: api/Employee/5
        [HttpPut("{id}")]
        public IActionResult UpdateEmployee(int id, [FromBody] Employee updated)
        {
            var employee = _context.Employees.Find(id);
            if (employee == null)
                return NotFound();

            employee.Name = updated.Name;
            employee.Department = updated.Department;
            employee.Salary = updated.Salary;

            _context.SaveChanges();
            return Ok(employee);
        }

        // DELETE: api/Employee/5
        [HttpDelete("{id}")]
        public IActionResult DeleteEmployee(int id)
        {
            var employee = _context.Employees.Find(id);
            if (employee == null)
                return NotFound();

            _context.Employees.Remove(employee);
            _context.SaveChanges();
            return NoContent();
        }
    }
}
