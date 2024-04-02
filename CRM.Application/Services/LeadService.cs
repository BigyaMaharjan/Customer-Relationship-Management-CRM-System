using CRM.Application.DTOs.LeadDto;
using CRM.Application.Persistence;
using CRM.Domain.Entities;

namespace CRM.Application.Services
{
    public class LeadService : ILeadService
    {
        public Task<LeadGetDto> AddAsync(LeadCreateDto createDto)
        {
            throw new NotImplementedException();
        }

        public Task AssigntoSalesRepresentative(int LeadId, int UserId)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<LeadGetDto>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<LeadGetDto> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<LeadGetDto> UpdateAsync(int id, LeadCreateDto updateDto)
        {
            throw new NotImplementedException();
        }
    }
}
