using EmployeeCustomProperties.Domain;
using EmployeeCustomProperties.Services.ViewModels.CustomPropertyDropdownService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCustomProperties.Services.ViewModels.CustomPropertyService
{
    public class AddCustomPropertyRequestViewModel
    {
        public PropertyType Type { get; set; }
        public bool IsRequired { get; set; }
        public string PropertyName { get; set; }
        public string Value { get; set; }
        public List<AddCustomPropertyDropdownRequestViewModel> DropdownRequests { get; set; } = new List<AddCustomPropertyDropdownRequestViewModel>();
         
    }
}
