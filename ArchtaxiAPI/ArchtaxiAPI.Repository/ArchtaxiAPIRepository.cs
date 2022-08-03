using ArchtaxiAPI.Models.Models;
using ArchtaxiAPI.Repository.Interface;
using Microsoft.EntityFrameworkCore;

namespace ArchtaxiAPI.Repository
{
    public class ArchtaxiAPIRepository : IArchtaxiAPIRepository
    {
        private TaxiBoxContext _context;

        public ArchtaxiAPIRepository(TaxiBoxContext context)
        {
            this._context = context;
        }

        public async Task<IEnumerable<Job>> GetJobs()
        {
            return await this._context.Jobs.ToListAsync();
        }

        public async Task<Job> GetJob(int id)
        {
            return await this._context.Jobs.Where(x => x.Id == id).FirstAsync();
        }

        public async Task<Job> DeleteJob(int id)
        {
            var job = await this._context.Jobs.Where(x => x.Id == id).FirstOrDefaultAsync();
                job.DeletedFlag = true;
                this._context.SaveChanges();
            return job;
        }


    }
}