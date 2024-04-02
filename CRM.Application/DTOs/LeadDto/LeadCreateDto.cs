﻿using CRM.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Application.DTOs.LeadDto
{
    public class LeadCreateDto
    {
        public Customer Customer { get; set; }

        public int UserId { get; set; }
        
        public User User { get; set; }

        public LeadStatus LeadStatus { get; set; }

    }
}