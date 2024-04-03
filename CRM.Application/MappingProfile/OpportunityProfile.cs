

namespace CRM.Application.MappingProfile
{
    public class OpportunityProfile : Profile
    {
        public OpportunityProfile() 
        {
            CreateMap<OpportunityCreateDto, Opportunity>().ReverseMap();    
            CreateMap<OpportunityGetDto, Opportunity>().ReverseMap();    


        }     
    }
}
