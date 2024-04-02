using AutoMapper;
using CRM.Application.DTOs.RoleDto;
using CRM.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
