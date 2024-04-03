
namespace CRM.Application.Persistence
{
    public  interface IUserService : IGeneralCrudService<User,UserCreateDto,UserGetDto>
    {
        Task AssignRoleToUser(int UserId, int RoleId);
    }
}
