

namespace CRM.Application.MappingProfile
{
    public class RoleProfile : Profile
    {
        public RoleProfile() { 
            CreateMap<RoleCreateDto,Roles>().ReverseMap();
            CreateMap<RoleGetDto,Roles>().ReverseMap();

        }
    }
}
