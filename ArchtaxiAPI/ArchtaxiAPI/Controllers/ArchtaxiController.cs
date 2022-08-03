using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ArchtaxiAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArchtaxiController : ControllerBase
    {
        // GET: api/<ArchtaxiController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<ArchtaxiController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ArchtaxiController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ArchtaxiController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ArchtaxiController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
