using ArchtaxiAPI.Models.Models;
using ArchtaxiAPI.Repository.Interface;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ArchtaxiAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArchtaxiController : ControllerBase
    {
        private IArchtaxiAPIRepository _archtaxi;

        public ArchtaxiController(IArchtaxiAPIRepository archtaxi)
        {
            this._archtaxi = archtaxi;
        }

        // GET: api/<ArchtaxiController>
        [HttpGet]
        [Route("getjobs")]
        public Task<IEnumerable<Job>> GetJobs()
        {
            return _archtaxi.GetJobs();
        }

        // GET: api/<ArchtaxiController>
        [HttpGet]
        [Route("getjob/{id}")]
        public Task<Job> GetJob(int id)
        {
            return _archtaxi.GetJob(id);
        }

        // DELETE: api/<ArchtaxiController>
        [HttpDelete]
        [Route("deletejob/{id}")]
        public Task<Job> DeleteJob(int id)
        {
            return _archtaxi.DeleteJob(id);
        }

    }
}
