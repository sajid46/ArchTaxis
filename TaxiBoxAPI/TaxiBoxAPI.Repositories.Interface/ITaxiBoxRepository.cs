using TaxiBoxAPI.Models.Models;

namespace TaxiBoxAPI.Repositories
{
    public interface ITaxiBoxRepository
    {
        Task<IEnumerable<Airport>> GetAirportsAsync();
        Task<IEnumerable<Job>> GetJobsAsync();
        Task<Job> GetJobAsync(int id);
        bool DeleteJobAsync(int id, bool logicDelete = true);
    }
}