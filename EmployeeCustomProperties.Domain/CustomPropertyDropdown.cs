using EmployeeCustomProperties.Domain.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCustomProperties.Domain
{
    public class CustomPropertyDropdown: BaseEntity
    {
        public string DropdownValue { get; set; }
        public int CustomPropertyId { get; set; }
        public virtual CustomProperty CustomProperty { get; set; }
    }
}
