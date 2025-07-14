using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace SimpleWebAPI.Controllers
{
    [ApiController]
    [Route("api/Emp")]
    public class EmployeeController : ControllerBase
    {
        private static List<string> employees = new List<string> { "Alice", "Bob" };

        [HttpGet(Name = "GetAllEmployees")]
        [ProducesResponseType(200)]
        public IActionResult Get() => Ok(employees);

        [HttpPost(Name = "AddEmployee")]
        [ProducesResponseType(200)]
        public IActionResult Post([FromBody] string employee)
        {
            employees.Add(employee);
            return Ok("Employee added");
        }
    }
}