

namespace CRM.Application.Services
{
    public class OpportunityService : IGeneralCrudService<Opportunity, OpportunityCreateDto, OpportunityGetDto>
    {
        public Task<OpportunityGetDto> AddAsync(OpportunityCreateDto createDto)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<OpportunityGetDto>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<OpportunityGetDto> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<OpportunityGetDto> UpdateAsync(int id, OpportunityCreateDto updateDto)
        {
            throw new NotImplementedException();
        }
    }
}
