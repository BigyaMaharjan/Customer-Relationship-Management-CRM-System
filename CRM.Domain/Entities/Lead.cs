
using CRM.Shared;

namespace CRM.Domain.Entities
{
    public class Lead: BaseEntity
    {
        
        public int CustomerId { get; set; }
        
        public Customer Customer { get; set; }
        
        public int UserId { get; set; }
        
        public User User { get; set; }

        public LeadStatus LeadStatus { get; set; }
        public ICollection<Opportunity> Opportunities { get; set; }
        public Lead()
        {
            CustomerId = default;
        }
    }
}
