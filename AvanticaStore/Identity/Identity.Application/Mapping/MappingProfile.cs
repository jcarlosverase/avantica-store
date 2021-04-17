using Identity.Application.Users.Queries;
using AutoMapper;
using Identity.Domain.Entities;

namespace Identity.Application.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            AllowNullDestinationValues = true;
            //Source -> Destination
            CreateMap<ApplicationUser, UserDto>();
        }
    }
}
