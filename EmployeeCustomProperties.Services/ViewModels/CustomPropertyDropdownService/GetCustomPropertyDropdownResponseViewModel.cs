using EmployeeCustomProperties.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCustomProperties.Services.ViewModels.CustomPropertyDropdownService
{
    public class GetCustomPropertyDropdownResponseViewModel
    {
        public GetCustomPropertyDropdownResponseViewModel(CustomPropertyDropdown customPropertyDropdown)
        {
            Id = customPropertyDropdown.Id;
            DropdownValue = customPropertyDropdown.DropdownValue;
            CustomPropertyId = customPropertyDropdown.CustomPropertyId;
        }
        public int Id { get; set; }
        public string DropdownValue { get; set; }
        public int CustomPropertyId { get; set; }
    }
}
