

namespace CRM.Application.MappingProfile
{
    public class CustomerProfile : Profile
    {
        public CustomerProfile()
        {
            CreateMap<CustomerCreateDto,Customer>().ReverseMap();
            CreateMap<CustomerGetDto, Customer>().ReverseMap();
        }
    }
}
