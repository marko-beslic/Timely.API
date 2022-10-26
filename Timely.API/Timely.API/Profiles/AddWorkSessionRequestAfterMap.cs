using AutoMapper;
using Timely.API.DomainModels;

namespace Timely.API.Profiles
{
    public class AddWorkSessionRequestAfterMap : IMappingAction<AddWorkSessionRequest, DataModels.WorkSession>
    {
        public void Process(AddWorkSessionRequest source, DataModels.WorkSession destination, ResolutionContext context)
        {
            destination.Id = Guid.NewGuid();
        }
    }
}
