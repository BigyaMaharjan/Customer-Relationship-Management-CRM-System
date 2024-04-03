
namespace CRM.Application.DTOs.LeadDto
{
    public class UpdateLeadStatusDto
    {
        public int LeadId { get; set; }
        public LeadStatus NewStatus { get; set; }
    }

}
