using AutoMapper;
using CRM.Application.DTOs.OpportunityDto;
using CRM.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
