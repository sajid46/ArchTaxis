using Microsoft.EntityFrameworkCore;
using TaxiBoxAPI.Models.Models;

namespace TaxiBoxAPI.Repositories
{
    public class TaxiBoxRepository : ITaxiBoxRepository
    {
        private TaxiBoxContext _context;

        public TaxiBoxRepository(TaxiBoxContext context)
        {
            this._context = context;
        }

        public bool DeleteJobAsync(int id, bool logicDelete = true)
        {
            var job = this._context.Jobs.Where(x => x.Id == id).FirstOrDefault();
            if (job != null) 
            {
                job.DeletedFlag = logicDelete; 
            }

            this._context.SaveChanges();

            return true;
            
        }

        public async Task<IEnumerable<Airport>> GetAirportsAsync()
        {
            return await this._context.Airports.ToListAsync();
        }

        public async Task<Job> GetJobAsync(int id)
        {
            return await this._context.Jobs.Where(o => o.Id == id).FirstAsync();
        }

        public async Task<IEnumerable<Job>> GetJobsAsync()
        {
            return await this._context.Jobs.ToListAsync();
        }
    }
}