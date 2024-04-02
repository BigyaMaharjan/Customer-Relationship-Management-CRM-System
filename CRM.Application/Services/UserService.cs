using CRM.Application.DTOs.UserDto;
using CRM.Application.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Application.Services
{
    public class UserService : IUserService
    {
        public Task<UserGetDto> AddAsync(UserCreateDto createDto)
        {
            throw new NotImplementedException();
        }

        public Task AssignRoleToUser(int UserId, int RoleId)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<UserGetDto>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<UserGetDto> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<UserGetDto> UpdateAsync(int id, UserCreateDto updateDto)
        {
            throw new NotImplementedException();
        }
    }
}
