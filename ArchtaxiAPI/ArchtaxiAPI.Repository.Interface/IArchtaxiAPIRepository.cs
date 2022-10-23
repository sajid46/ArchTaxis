using ArchtaxiAPI.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchtaxiAPI.Repository.Interface
{
    public interface IArchtaxiAPIRepository
    {
        Task<IEnumerable<Job>> GetJobs();
        Task<Job> GetJob(int id);
        Task<Job> DeleteJob(int id);
    }
}
