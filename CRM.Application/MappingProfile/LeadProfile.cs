

namespace CRM.Application.MappingProfile
{
    public class LeadProfile : Profile
    {
        public LeadProfile() { 
        CreateMap<LeadCreateDto,Lead>().ReverseMap();
        CreateMap<LeadGetDto,Lead>().ReverseMap();
        CreateMap<UpdateLeadStatusDto, Lead>().ReverseMap();
        CreateMap<AssignSalesRepresentativeDto, Lead>().ReverseMap();

        }
    }
}
