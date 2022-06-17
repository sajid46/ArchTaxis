using TaxiBoxAPI.Models.Models;

namespace TaxiBoxAPI.Repositories
{
    public interface ITaxiBoxRepository
    {
        Task<IEnumerable<Airport>> GetAirportsAsync();
        Task<IEnumerable<Job>> GetJobsAsync();
        bool DeleteJobAsync(int id, bool logicDelete = true);
    }
}