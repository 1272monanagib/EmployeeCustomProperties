using EmployeeCustomProperties.Domain;
using EmployeeCustomProperties.Services.ViewModels.CustomPropertyDropdownService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCustomProperties.Services.ViewModels.CustomPropertyService
{
    public class GetCustomPropertyResponseViewModel
    {
        public GetCustomPropertyResponseViewModel(CustomProperty customProperty)
        {
            Id = customProperty.Id;
            Type = customProperty.Type;
            IsRequired = customProperty.IsRequired;
            Value = customProperty.Value;
            PropertyName = customProperty.PropertyName;
            CustomPropertyDropdowns = customProperty.CustomPropertyDropdowns.Select(d => new GetCustomPropertyDropdownResponseViewModel(d)).ToList();

        }
        public int Id { get; set; }
        public PropertyType Type { get; set; }
        public bool IsRequired { get; set; }
        public string PropertyName { get; set; }
        public string Value { get; set; }
        public List<GetCustomPropertyDropdownResponseViewModel> CustomPropertyDropdowns { get; set; } = new List<GetCustomPropertyDropdownResponseViewModel>();
       
    }
}
