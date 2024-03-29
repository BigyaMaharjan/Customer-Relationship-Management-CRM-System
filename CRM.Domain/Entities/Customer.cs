using CRM.Shared;

namespace CRM.Domain.Entities
{
    public class Customer : BaseEntity
    {        
        public string CustomerName { get; set; }
        public string Email { get; set; }
        public double MobileNumber { get; set; }
        public string Company { get; set; }
        public string Department { get; set; }
        public ICollection<Lead> Leads { get; set; }
    }
}
