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

        //https://localhost:7294/api/jobs/delete/5001
        [HttpGet]
        [Route("logicdelete/{id}")]
        public bool DeleteJob(int id)
        {
            return this._taxiBoxRepository.DeleteJobAsync(id);
        }

        //https://localhost:7294/api/jobs/undodelete/5001
        [HttpGet]
        [Route("logicdelete/{id}")]
        public bool UndoDeleteJob(int id)
        {
            return this._taxiBoxRepository.DeleteJobAsync(id, false);
        }

    }
}
