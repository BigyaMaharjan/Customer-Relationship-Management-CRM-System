
namespace CRM.Application.Persistence
{
    public  interface IUserService : IGeneralCrudService<User,UserCreateDto,UserGetDto>
    {
        Task AssignRoleToUser(AssignRoleToUserDto dto);
        
    }
}
