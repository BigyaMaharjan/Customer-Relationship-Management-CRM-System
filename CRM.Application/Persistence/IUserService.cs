using CRM.Application.DTOs.UserDto;
using CRM.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Application.Persistence
{
    public  interface IUserService : IGeneralCrudService<User,UserCreateDto,UserGetDto>
    {
        Task AssignRoleToUser(int UserId, int RoleId);
    }
}
