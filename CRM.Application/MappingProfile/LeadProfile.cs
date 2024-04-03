using AutoMapper;
using CRM.Application.DTOs.LeadDto;
using CRM.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

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
