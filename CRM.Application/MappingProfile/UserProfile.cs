

namespace CRM.Application.MappingProfile
{
    public class Userprofile : Profile
    {
        public Userprofile() 
        {
            CreateMap<UserCreateDto,User>().ReverseMap();
            CreateMap<UserGetDto, User>().ReverseMap();
        }    
    }
}
