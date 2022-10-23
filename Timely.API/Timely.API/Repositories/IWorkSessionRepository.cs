using Timely.API.DataModels;

namespace Timely.API.Repositories
{
    public interface IWorkSessionRepository
    {
        Task<List<WorkSession>> GetWorkSessionsAsync();
    }
}
