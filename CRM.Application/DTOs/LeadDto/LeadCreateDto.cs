
namespace CRM.Application.DTOs.LeadDto
{
    public class LeadCreateDto
    {
        public Customer Customer { get; set; }

        public int UserId { get; set; }
        
        public User User { get; set; }

        public LeadStatus LeadStatus { get; set; }

    }
}
