using AutoMapper;
using CRM.Application.DTOs.CustomerDto;
using CRM.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Application.MappingProfile
{
    public class CustomerProfile : Profile
    {
        public CustomerProfile()
        {
            CreateMap<CustomerCreateDto,Customer>().ReverseMap();
            CreateMap<leadGetDto, Customer>().ReverseMap();
        }
    }
}
