using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JLPayWebApp.Pages;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace JLPayWebApp.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class CallbackController : ControllerBase
    {
        // GET: api/<CallbackController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            QrcodePayModel.TestModel = "test";
            return new string[] { "value1", "value2" };
        }

        // GET api/<CallbackController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<CallbackController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<CallbackController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CallbackController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
