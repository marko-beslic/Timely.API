using Microsoft.AspNetCore.Mvc;
using Timely.API.DataModels;
using Timely.API.Repositories;
using Timely.API.DomainModels;
using WorkSession = Timely.API.DomainModels.WorkSession;
using AutoMapper;

namespace Timely.API.Controllers
{
    [ApiController]
    public class WorkSessionsController : Controller
    {
        private readonly IWorkSessionRepository workSessionRepository;
        private readonly IMapper mapper;

        public WorkSessionsController(IWorkSessionRepository workSessionRepository, IMapper mapper)
        {
            this.workSessionRepository = workSessionRepository;
            this.mapper = mapper;
        }
        [HttpGet]
        [Route("[controller]")]
        public async Task<IActionResult> GetAllWorkSessions()
        {
            var workSessions = await workSessionRepository.GetWorkSessionsAsync();

            return Ok(mapper.Map<List<WorkSession>>(workSessions));
        }

        [HttpPost]
        [Route("[controller]/Add")]
        public async Task<ActionResult> AddWorkSessionAsync([FromBody] AddWorkSessionRequest request)
        {
            var workSession = await workSessionRepository.AddWorkSession(mapper.Map<DataModels.WorkSession>(request));
            return CreatedAtAction("GetWorkSession", new { workSessionId = workSession.Id },
                mapper.Map<WorkSession>(workSession));
        }
    }
}
