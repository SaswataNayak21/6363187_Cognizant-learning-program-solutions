using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace SimpleWebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ValuesController : ControllerBase
    {
        private static List<string> values = new List<string> { "value1", "value2" };

        [HttpGet]
        public IActionResult Get() => Ok(values);

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            if (id < 0 || id >= values.Count)
                return NotFound("Value not found");

            return Ok(values[id]);
        }

        [HttpPost]
        public IActionResult Post([FromBody] string value)
        {
            values.Add(value);
            return Ok("Value added");
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] string value)
        {
            if (id < 0 || id >= values.Count)
                return NotFound("Value not found");

            values[id] = value;
            return Ok("Value updated");
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            if (id < 0 || id >= values.Count)
                return NotFound("Value not found");

            values.RemoveAt(id);
            return Ok("Value deleted");
        }
    }
}