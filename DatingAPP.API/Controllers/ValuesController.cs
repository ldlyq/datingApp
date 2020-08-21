using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DatingAPP.API.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DatingAPP.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly DataContext _context;
        public ValuesController(DataContext context)
        {
            _context = context;

        }
        // GET: api/values
        [HttpGet]
        public async Task<IActionResult> GetValues()
        {
            // throw new Exception("Test Exception");
            var values = await _context.values.ToListAsync();
            return Ok(values);
        }

        // GET api/values/5 
        [HttpGet("{id}")]
        public IActionResult GetValue(int id)
        {
            var value = _context.values.FirstOrDefault(x => x.Id == id);
            return Ok(value);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}