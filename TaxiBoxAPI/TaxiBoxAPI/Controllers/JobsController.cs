using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TaxiBoxAPI.Models.Models;
using TaxiBoxAPI.Repositories;

namespace TaxiBoxAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobsController : ControllerBase
    {
        private ITaxiBoxRepository _taxiBoxRepository;

        public JobsController(ITaxiBoxRepository taxiBoxRepository)
        {
            this._taxiBoxRepository = taxiBoxRepository;
        }

        //https://localhost:7294/api/jobs/jobs
        [HttpGet]
        [Route("jobs")]
        public async Task<IEnumerable<Job>> GetJobs()
        {
            return await this._taxiBoxRepository.GetJobsAsync();
        }

        //https://localhost:7294/api/jobs/job/5001
        [HttpGet]
        [Route("job/{id}")]
        public async Task<Job> GetJob(int id)
        {
            return await this._taxiBoxRepository.GetJobAsync(id);
        }

        //https://localhost:7294/api/jobs/delete/5001/true
        [HttpGet]
        [Route("delete/{id}/{delete}")]
        public bool DeleteJob(int id)
        {
            return this._taxiBoxRepository.DeleteJobAsync(id, true);
        }

        //https://localhost:7294/api/jobs/undodelete/5001
        [HttpGet]
        [Route("undodelete/{id}")]
        public bool UndoDeleteJob(int id)
        {
            return this._taxiBoxRepository.DeleteJobAsync(id, false);
        }

    }
}
