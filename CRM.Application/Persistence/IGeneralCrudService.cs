﻿

namespace CRM.Application.Persistence
{
    public interface IGeneralCrudService<T, TCreateDto, TGetDto> where T : class
    {
        Task<TGetDto> GetByIdAsync(int id);
        Task<IEnumerable<TGetDto>> GetAllAsync();
        Task<TGetDto> AddAsync(TCreateDto createDto);
        Task<TGetDto> UpdateAsync(int id, TCreateDto updateDto);
        Task DeleteAsync(int id);
    }
}
