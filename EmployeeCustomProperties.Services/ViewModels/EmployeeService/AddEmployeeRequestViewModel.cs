using EmployeeCustomProperties.Domain;
using EmployeeCustomProperties.Services.ViewModels.CustomPropertyService;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCustomProperties.Services.ViewModels.EmployeeService
{
    public class AddEmployeeRequestViewModel
    {
        [Required]
        public string Code { get; set; }
        [Required]
        public string Name { get; set; }
        public string CustomPropertiesJson { get; set; }
        //public List<AddCustomPropertyRequestViewModel> CustomPropertiesRequest { get; set; } = new List<AddCustomPropertyRequestViewModel>();
    }
  
}
