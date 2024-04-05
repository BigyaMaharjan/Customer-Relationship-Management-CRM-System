

using System.Reflection.Metadata.Ecma335;

namespace CRM.Application.Services
{
    public class RoleService : IGeneralCrudService<Roles, RoleCreateDto, RoleGetDto>
    {
        private readonly CRMDbContext _dbContext;
        private readonly IMapper _mapper;
        public async Task<RoleGetDto> AddAsync(RoleCreateDto createDto)
        {
            var role = _mapper.Map<Roles>(createDto);
            _dbContext.Roles.Add(role);
            await _dbContext.SaveChangesAsync();
            return _mapper.Map<RoleGetDto>(role);
        }

        public async Task DeleteAsync(int id)
        {
            var role = await _dbContext.Roles.FindAsync(id);
            if (role == null)
            {
                throw new Exception($"Role with Id: {id} was not found");
            }
            _dbContext.Roles.Remove(role);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<RoleGetDto>> GetAllAsync()
        {
            var roles = await _dbContext.Roles.ToListAsync();
            return _mapper.Map<IEnumerable<RoleGetDto>>(roles);
        }

        public async Task<RoleGetDto> GetByIdAsync(int id)
        {
            var role = await _dbContext.Roles.FindAsync(id);
            if (role == null)
            {
                throw new Exception($"Role with Id: {id} was not found");
            }
            return _mapper.Map<RoleGetDto>(role);
        }

        public async Task<RoleGetDto> UpdateAsync(int id, RoleCreateDto updateDto)
        {
            var role = await _dbContext.Roles.FindAsync(id);
            if (role == null)
            {
                throw new Exception($"Role with Id: {id} was not found");
            }
            _mapper.Map(role, updateDto);
            await _dbContext.SaveChangesAsync();
            return _mapper.Map<RoleGetDto>(role);
        }
    }
}
