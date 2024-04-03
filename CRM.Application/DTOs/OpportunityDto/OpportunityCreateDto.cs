
namespace CRM.Application.DTOs.OpportunityDto
{
    public class OpportunityCreateDto
    {
        public int PotentialRevenue { get; set; }
        public float ClosingProbability { get; set; }
        public DateTime CloseDate { get; set; }
        public OpportunityStatus OpportunityStatus { get; set; }
    }
}
