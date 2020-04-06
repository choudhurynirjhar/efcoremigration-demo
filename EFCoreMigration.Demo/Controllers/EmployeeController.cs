using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace EFCoreMigration.Demo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly EmployeeContext employeeContext;

        public EmployeeController(EmployeeContext employeeContext)
        {
            this.employeeContext = employeeContext;
        }

        // GET: api/Employee
        [HttpGet]
        public IEnumerable<Employee> Get()
        {
            return employeeContext.Employees;
        }

        // POST: api/Employee
        [HttpPost]
        public void Post([FromBody] Employee employee)
        {
            employeeContext.Add(employee);
            employeeContext.SaveChanges();
        }
    }
}
