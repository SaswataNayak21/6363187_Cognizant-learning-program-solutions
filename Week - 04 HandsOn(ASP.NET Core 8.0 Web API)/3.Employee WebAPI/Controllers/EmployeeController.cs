using Microsoft.AspNetCore.Mvc;
using SimpleWebAPI.Models;
using SimpleWebAPI.Filters;
using System;
using System.Collections.Generic;

namespace SimpleWebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [ServiceFilter(typeof(CustomAuthFilter))]
    [TypeFilter(typeof(CustomExceptionFilter))]
    public class EmployeeController : ControllerBase
    {
        private List<Employee> GetStandardEmployeeList()
        {
            return new List<Employee>
            {
                new Employee
                {
                    Id = 1,
                    Name = "Alice",
                    Salary = 50000,
                    Permanent = true,
                    Department = new Department { Id = 1, Name = "HR" },
                    Skills = new List<Skill> { new Skill { Id = 1, Name = "Communication" } },
                    DateOfBirth = new DateTime(1990, 1, 1)
                },
                new Employee
                {
                    Id = 2,
                    Name = "Bob",
                    Salary = 60000,
                    Permanent = false,
                    Department = new Department { Id = 2, Name = "IT" },
                    Skills = new List<Skill> { new Skill { Id = 2, Name = "C#" }, new Skill { Id = 3, Name = "SQL" } },
                    DateOfBirth = new DateTime(1988, 5, 15)
                }
            };
        }

        [HttpGet("GetStandard")]
        [ProducesResponseType(200)]
        [ProducesResponseType(500)]
        [AllowAnonymous]
        public ActionResult<List<Employee>> GetStandard()
        {
            throw new Exception("Simulated exception");
            // return Ok(GetStandardEmployeeList());
        }

        [HttpPost]
        public IActionResult Post([FromBody] Employee employee)
        {
            return Ok($"Employee {employee.Name} added.");
        }
    }
}