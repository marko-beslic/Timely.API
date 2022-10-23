using AutoMapper;
using Timely.API.DomainModels;
using DataModels = Timely.API.DataModels;

namespace Timely.API.Profiles
{
    public class AutoMapperProfiles: Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<DataModels.WorkSession, WorkSession>()
                .ReverseMap();
        }
    }
}
