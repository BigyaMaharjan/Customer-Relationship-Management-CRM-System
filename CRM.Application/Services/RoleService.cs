

namespace CRM.Application.Services
{
    internal class RoleService : IGeneralCrudService<Roles, RoleCreateDto, RoleGetDto>
    {
        public Task<RoleGetDto> AddAsync(RoleCreateDto createDto)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<RoleGetDto>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<RoleGetDto> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<RoleGetDto> UpdateAsync(int id, RoleCreateDto updateDto)
        {
            throw new NotImplementedException();
        }
    }
}
