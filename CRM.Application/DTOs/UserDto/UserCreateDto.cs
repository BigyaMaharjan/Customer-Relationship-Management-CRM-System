using CRM.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
