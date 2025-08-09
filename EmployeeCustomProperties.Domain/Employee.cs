using EmployeeCustomProperties.Domain.Shared;
using System.ComponentModel.DataAnnotations;

namespace EmployeeCustomProperties.Domain
{
    public class Employee: BaseEntity
    {
        [Required]
        public string Code { get; set; }
        [Required]
        public string Name { get; set; }
        public ICollection<CustomProperty> CustomProperties { get; set; } = new List<CustomProperty>();

    }
}
