using Application.Works;
using AutoMapper;
using Domain;

namespace Application.Core
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Work, Work>();
            CreateMap<Work, WorkDto>();
            CreateMap<ScheduleWork, ScheduleDto>()
                .ForMember(d => d.Date, o => o.MapFrom(s => s.Schedule.Date))
                .ForMember(d => d.Score, o => o.MapFrom(s => s.Score))
                .ForMember(d => d.Finish, o => o.MapFrom(s => s.Finish));
        }
    }
}