

namespace CRM.Application.DTOs.OpportunityDto
{
    public class OpportunityUpdateDto
    {
        public int PotentialRevenue { get; set; }
        public float ClosingProbability { get; set; }
        public DateTime CloseDate { get; set; }
        public OpportunityStatus OpportunityStatus { get; set; }
    }
}
