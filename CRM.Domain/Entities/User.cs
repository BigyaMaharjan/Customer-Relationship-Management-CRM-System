

using CRM.Shared;

namespace CRM.Domain.Entities
{
    public class User: BaseEntity
    {
        
        public string UserName { get; set; }
        public string Password { get; set; }
        
        public int RolesId{ get; set; }
        
        public Roles Roles { get; set; }
        public ICollection<Lead> Leads { get; set; }
    }
}
