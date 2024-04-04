
using CRM.Application.DTOs.UserDto;

namespace CRM.Application.Services
{
    public class UserService : IUserService
    {
        private readonly CRMDbContext _dbContext;
        private readonly IMapper _mapper; 
        public async Task<UserGetDto> AddAsync(UserCreateDto createDto)
        {
            var user = _mapper.Map<User>(createDto);
            _dbContext.Users.Add(user);
            await _dbContext.SaveChangesAsync();
            return _mapper.Map<UserGetDto>(user);
        }

        public async Task AssignRoleToUser(AssignRoleToUserDto dto)
        {
            var user = await _dbContext.Users.SingleOrDefaultAsync(u => u.Id == dto.UserID);
            if (user != null)
            {
                _mapper.Map(dto, user);
                await _dbContext.SaveChangesAsync();    
            }
            else
            {
                throw new Exception("User not Found");
            }
            
        }

        public async Task DeleteAsync(int id)
        {
            var user=await _dbContext.Users.FindAsync(id);
            if (user == null)
            {
                throw new Exception("User not found");
            }
            _dbContext.Users.Remove(user);  
            await _dbContext.SaveChangesAsync();    
        }

        public async Task<IEnumerable<UserGetDto>> GetAllAsync()
        {
            var users = await _dbContext.Users.ToListAsync();
            return _mapper.Map<IEnumerable<UserGetDto>>(users);
        }

        public async Task<UserGetDto> GetByIdAsync(int id)
        {
            var user = await _dbContext.Users.FindAsync(id);
            if (user == null) 
            {
                throw new Exception($"No User with the given {id}");
            }
            return _mapper.Map<UserGetDto>(user);
        }

        public async Task<UserGetDto> UpdateAsync(int id, UserCreateDto updateDto)
        {
            var user = await _dbContext.Users.FindAsync(id);
            if (user == null)
            {
                throw new Exception($"No  user with the given {id}");
            }
            _mapper.Map(updateDto, user);
            await _dbContext.SaveChangesAsync();
            return _mapper.Map<UserGetDto>(user);
        } 
    }
}
