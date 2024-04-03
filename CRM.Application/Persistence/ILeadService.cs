
namespace CRM.Application.Persistence
{
    public interface ILeadService : IGeneralCrudService<Lead,LeadCreateDto,LeadGetDto>
    {
        Task AssignToSalesRepresentative(AssignSalesRepresentativeDto dto);
        Task UpdateLeadStatus(UpdateLeadStatusDto dto);
    }
}
