﻿using CRM.Application.DTOs.LeadDto;
using CRM.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Application.Persistence
{
    public interface ILeadService : IGeneralCrudService<Lead,LeadCreateDto,LeadGetDto>
    {
        Task AssigntoSalesRepresentative(int LeadId, int UserId);
    }
}