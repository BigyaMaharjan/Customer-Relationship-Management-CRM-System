﻿using CRM.Application.DTOs.OpportunityDto;
using CRM.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Application.Persistence
{
    public interface IOpportunityService : IGeneralCrudService<Opportunity, OpportunityCreateDto, OpportunityGetDto>
    {

    }
}
