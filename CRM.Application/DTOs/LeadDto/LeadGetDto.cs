using CRM.Domain.Entities;

namespace CRM.Application.DTOs.LeadDto
{
    public class LeadGetDto
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }

        public Customer Customer { get; set; }

        public int UserId { get; set; }

        public User User { get; set; }

        public LeadStatus LeadStatus { get; set; }
        public ICollection<Opportunity> Opportunities { get; set; }
    }
}