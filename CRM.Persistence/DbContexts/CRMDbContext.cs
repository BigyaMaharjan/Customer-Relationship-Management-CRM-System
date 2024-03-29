using CRM.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CRM.Persistence.DbContexts
{
    public class CRMDbContext : DbContext
    {
        public CRMDbContext(DbContextOptions<CRMDbContext> options) : base(options)
        {

        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Lead> Leads { get; set; }
        public DbSet<Opportunity> Opportunities { get; set; }
        public DbSet<Roles> Roles { get; set; }
        public DbSet<User> Users { get; set; }        
    }
}
