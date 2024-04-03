using AutoMapper;
using CRM.Application.DTOs.LeadDto;
using CRM.Application.Persistence;
using CRM.Domain.Entities;
using CRM.Persistence.DbContexts;
using Microsoft.EntityFrameworkCore;

namespace CRM.Application.Services
{
    public class LeadService : ILeadService
    {
        private readonly  CRMDbContext _dbContext;
        private readonly  IMapper _mapper;
        public async Task<LeadGetDto> AddAsync(LeadCreateDto createDto)
        {
            var lead =_mapper.Map<Lead>(createDto);
            _dbContext.Leads.Add(lead);
            await _dbContext.SaveChangesAsync();
            return _mapper.Map<LeadGetDto>(lead);
        }

        public async Task AssignToSalesRepresentative(AssignSalesRepresentativeDto dto)
        {
            var lead = await _dbContext.Leads.SingleOrDefaultAsync(l => l.Id == dto.LeadId);
            if (lead != null)
            {
                _mapper.Map(dto, lead);
                await _dbContext.SaveChangesAsync();
            }
            else
            {
                throw new Exception("Lead not found");
            }
        }


        public async Task DeleteAsync(int id)
        {
            var lead=await _dbContext.Leads.FindAsync(id);
            if (lead == null)
            {
                throw new Exception("Lead is not Found");
            }
            _dbContext.Leads.Remove(lead);
            await _dbContext.SaveChangesAsync();    
        }

        public async Task<IEnumerable<LeadGetDto>> GetAllAsync()
        {
            var leads=await _dbContext.Leads.ToListAsync();
            return _mapper.Map<IEnumerable<LeadGetDto>>(leads);
        }

        public async Task<LeadGetDto> GetByIdAsync(int id)
        {
            var lead = await _dbContext.Leads.FindAsync(id);
            if (lead == null)
            {
                throw new Exception($"No Lead with the  given {id}");
            }
            return _mapper.Map<LeadGetDto>(lead);
        }

        public async Task<LeadGetDto> UpdateAsync(int id, LeadCreateDto updateDto)
        {
            var lead = await _dbContext.Leads.FindAsync( id);
            if (lead == null)
            {
                throw new Exception($"No Lead with the  given {id}");
            }
            _mapper.Map(updateDto,lead);
            await _dbContext.SaveChangesAsync();
            return _mapper.Map<LeadGetDto>(lead);
        }

        public async Task UpdateLeadStatus(UpdateLeadStatusDto dto)
        {
            var lead = await _dbContext.Leads.SingleOrDefaultAsync(l => l.Id == dto.LeadId);

            if (lead == null)
            {
                throw new Exception("Lead not found.");
            }

            _mapper.Map(dto, lead);
            await _dbContext.SaveChangesAsync();
        }
    }
}
