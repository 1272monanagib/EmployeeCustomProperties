using EmployeeCustomProperties.Domain;
using EmployeeCustomProperties.Services.ViewModels.CustomPropertyService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCustomProperties.Services.ViewModels.EmployeeService
{
    public class GetEmployeeRepsonseViewModel
    {
        public GetEmployeeRepsonseViewModel(Employee employee)
        {
            Id = employee.Id;
            Code = employee.Code;
            Name = employee.Name;
            CustomPropertiesResponse = employee.CustomProperties.Select(cp => new GetCustomPropertyResponseViewModel(cp)).ToList();
        }
        public int Id { get; set; }

        public string Code { get; set; }

        public string Name { get; set; }
        public List<GetCustomPropertyResponseViewModel> CustomPropertiesResponse { get; set; } = new List<GetCustomPropertyResponseViewModel>();
      
    }
}
