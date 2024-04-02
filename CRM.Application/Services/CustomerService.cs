using CRM.Application.DTOs.CustomerDto;
using CRM.Application.Persistence;
using CRM.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Application.Services
{
    public class CustomerService : IGeneralCrudService<Customer, CustomerCreateDto, leadGetDto>
    {
        public Task<leadGetDto> AddAsync(CustomerCreateDto createDto)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<leadGetDto>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<leadGetDto> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<leadGetDto> UpdateAsync(int id, CustomerCreateDto updateDto)
        {
            throw new NotImplementedException();
        }
    }
}
