using AutoMapper;
using CRM.Application.DTOs.UserDto;
using CRM.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
