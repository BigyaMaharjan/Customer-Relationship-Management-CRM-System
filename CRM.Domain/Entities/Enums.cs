namespace CRM.Domain.Entities
{
    public enum LeadStatus
    {
        New,
        Contacted,
        Qualified,
        Converted,        
        LeadLost
    }

    public enum OpportunityStatus
    {
        Prospecting,
        Qualification,
        Proposal,
        Negotiation
    }
    public enum RoleName
    {
        Manager,
        SalesRepresentative
    }
}
