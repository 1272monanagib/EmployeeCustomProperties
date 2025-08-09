using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCustomProperties.Services.ViewModels.CustomPropertyDropdownService
{
    public class AddCustomPropertyDropdownRequestViewModel
    {
        public string DropdownValue { get; set; }
        public int CustomPropertyId { get; set; }
    }
}
