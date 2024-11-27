using AdminPortalEmployee.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AdminPortalEmployee.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly AppDbContext _dbContext;

        public EmployeesController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult GetAllEmployees()
        {
           var allEmployees = _dbContext.Employees.ToList();

            return Ok(allEmployees);
        }
    }
}
