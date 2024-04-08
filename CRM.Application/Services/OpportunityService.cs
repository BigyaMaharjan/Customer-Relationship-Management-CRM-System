

namespace CRM.Application.Services
{
    public class OpportunityService : IGeneralCrudService<Opportunity, OpportunityCreateDto, OpportunityGetDto>
    {
        private readonly CRMDbContext _dbContext;
        private readonly IMapper _mapper;
        public async Task<OpportunityGetDto> AddAsync(OpportunityCreateDto createDto)
        {
            var opportunity = _mapper.Map<Opportunity>(createDto);
            _dbContext.Opportunities.Add(opportunity);
            await _dbContext.SaveChangesAsync();
            return _mapper.Map<OpportunityGetDto>(opportunity);
        }

        public async Task DeleteAsync(int id)
        {
            var opportunity = await _dbContext.Opportunities.FindAsync(id);
            if (opportunity == null)
            {
                throw new Exception($"Opportunity with Id: {id} was not found");
            }
            _dbContext.Opportunities.Remove(opportunity);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<OpportunityGetDto>> GetAllAsync()
        {
            var opportunities = await _dbContext.Opportunities.ToListAsync();
            return _mapper.Map<IEnumerable<OpportunityGetDto>>(opportunities);
        }

        public async Task<OpportunityGetDto> GetByIdAsync(int id)
        {
            var opportunity = await _dbContext.Opportunities.FindAsync(id);
            if (opportunity == null)
            {
                throw new Exception($"Opportunity with Id: {id} was not found");
            }
            return _mapper.Map<OpportunityGetDto>(opportunity);
        }

        public async Task<OpportunityGetDto> UpdateAsync(int id, OpportunityCreateDto updateDto)
        {
            var opportunity = await _dbContext.Opportunities.FindAsync(id);
            if (opportunity == null)
            {
                throw new Exception($"Opportunity with Id: {id} was not found");
            }
            _mapper.Map(updateDto, opportunity);
            await _dbContext.SaveChangesAsync();
            return _mapper.Map<OpportunityGetDto>(opportunity);
        }
    }
}
