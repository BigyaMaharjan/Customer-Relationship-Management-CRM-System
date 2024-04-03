using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Application.DTOs.CustomerDto
{
    public class CustomerCreateDto
    {
        public string CustomerName { get; set; }
        public string Email { get; set; }
        public double MobileNumber { get; set; }
        public string Company { get; set; }
        public string Department { get; set; }
    }
}
