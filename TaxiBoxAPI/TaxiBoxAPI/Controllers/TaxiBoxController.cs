using Microsoft.AspNetCore.Mvc;
using TaxiBoxAPI.Models.Models;
using TaxiBoxAPI.Repositories;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TaxiBoxAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaxiBoxController : ControllerBase
    {
        private ITaxiBoxRepository _taxiBoxRepository;

        public TaxiBoxController(ITaxiBoxRepository taxiBoxRepository)
        {
            this._taxiBoxRepository = taxiBoxRepository;
        }

        // GET: api/<TaxiBoxController>
        [HttpGet]
        [Route("Airports")]
        public async Task<IEnumerable<Airport>> GetAirports()
        {
            return await _taxiBoxRepository.GetAirportsAsync();
        }

        // GET api/<TaxiBoxController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<TaxiBoxController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<TaxiBoxController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<TaxiBoxController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
