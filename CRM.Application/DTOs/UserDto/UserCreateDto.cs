

namespace CRM.Application.DTOs.UserDto
{
    public class UserCreateDto
    {
        public string UserName { get; set; }
        public string Password { get; set; }

        public int RolesId { get; set; }

        public Roles Roles { get; set; }
        
    }
}
