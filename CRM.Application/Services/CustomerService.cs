

namespace CRM.Application.Services
{
    public class CustomerService : IGeneralCrudService<Customer, CustomerCreateDto, CustomerGetDto>
    {
        private readonly CRMDbContext _dbContext;
        private readonly IMapper _mapper;

        public async Task<CustomerGetDto> AddAsync(CustomerCreateDto createDto)
        {
            var customer = _mapper.Map<Customer>(createDto);
            _dbContext.Customers.Add(customer);
            await _dbContext.SaveChangesAsync();
            return _mapper.Map<CustomerGetDto>(customer);

        }

        public async Task DeleteAsync(int id)
        {
            var customer = await _dbContext.Customers.FindAsync(id);
            if (customer == null)
            {
                throw new Exception("Customer is not found");
            }
            _dbContext.Customers.Remove(customer);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<CustomerGetDto>> GetAllAsync()
        {
            var customers = await _dbContext.Customers.ToListAsync();
            return _mapper.Map<IEnumerable<CustomerGetDto>>(customers);
        }

        public async Task<CustomerGetDto> GetByIdAsync(int id)
        {
            var customer = await _dbContext.Customers.FindAsync(id);
            if (customer == null)
            {
                throw new Exception($"No Customer with given {id}");
            }
            return _mapper.Map<CustomerGetDto>(customer);
        }

        public async Task<CustomerGetDto> UpdateAsync(int id, CustomerCreateDto updateDto)
        {
            var customer = await _dbContext.Customers.FindAsync(id);
            if (customer == null)
            {
                throw new Exception($"No Customer with given {id}");
            }
            _mapper.Map(updateDto, customer);
            await _dbContext.SaveChangesAsync();
            return _mapper.Map<CustomerGetDto>(customer);
        }
    }
}
