using EmployeeCustomProperties.Domain.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCustomProperties.Domain
{
    public class CustomProperty: BaseEntity
    {
        public PropertyType Type { get; set; }
        public bool IsRequired { get; set; }
        public string PropertyName { get; set; }
        public string Value { get; set; }
        public virtual ICollection<CustomPropertyDropdown> CustomPropertyDropdowns { get; set; }  = new List<CustomPropertyDropdown>();
        public int EmployeeId { get; set; }
        public virtual Employee Employee { get; set; }  
    }
}
