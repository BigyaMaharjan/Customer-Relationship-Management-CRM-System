using System.ComponentModel.DataAnnotations;

namespace CRM.Shared
{
    public abstract class BaseEntity
    {
        [Required, Key]
        public int Id { get; set; }
    }
}
