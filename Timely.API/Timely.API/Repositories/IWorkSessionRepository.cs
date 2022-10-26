using Timely.API.DataModels;

namespace Timely.API.Repositories
{
    public interface IWorkSessionRepository
    {
        Task<List<WorkSession>> GetWorkSessionsAsync();

        Task<WorkSession> AddWorkSession(WorkSession request);
    }
}
