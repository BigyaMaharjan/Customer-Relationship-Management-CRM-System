
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
