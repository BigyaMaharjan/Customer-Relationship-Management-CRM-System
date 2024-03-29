
using CRM.Shared;

namespace CRM.Domain.Entities
{
    public class Opportunity: BaseEntity
    {
        
        public int LeadId { get; set; }
        
        public Lead Lead { get; set; }
        public int PotentialRevenue { get; set; }
        public float ClosingProbability { get; set; }
        public DateTime CloseDate { get; set; }        
        public OpportunityStatus OpportunityStatus { get; set; }

    }
}
