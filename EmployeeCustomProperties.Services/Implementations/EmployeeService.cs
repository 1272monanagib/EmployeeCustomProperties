using EmployeeCustomProperties.Domain;
using EmployeeCustomProperties.Repository.Interfaces;
using EmployeeCustomProperties.Services.Interfaces;
using EmployeeCustomProperties.Services.ViewModels.CustomPropertyService;
using EmployeeCustomProperties.Services.ViewModels.EmployeeService;
using EmployeeCustomProperties.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCustomProperties.Services.Implementations
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public async Task<ServiceResponse<GetEmployeeRepsonseViewModel>> AddEmployee(AddEmployeeRequestViewModel addEmployeeRequestViewModel)
        {
            try
            {
                var newEmployee = new Employee
                {
                    Code = addEmployeeRequestViewModel.Code,
                    Name = addEmployeeRequestViewModel.Name,
                    CustomProperties = addEmployeeRequestViewModel.CustomPropertiesRequest
                        .Select(cp => new CustomProperty
                        {
                            Type = cp.Type,
                            IsRequired = cp.IsRequired,
                            PropertyName = cp.PropertyName,
                            Value = cp.Value.ToString(),
                            CustomPropertyDropdowns = cp.Type == PropertyType.Dropdown && cp.DropdownRequests != null
                        ? cp.DropdownRequests
                            .Select(d => new CustomPropertyDropdown
                            {
                                DropdownValue = d.DropdownValue
                            })
                            .ToList()
                        : new List<CustomPropertyDropdown>()
                        })
                     .ToList()
          
                };
                await _employeeRepository.AddEmployeeAsync(newEmployee);
                await _employeeRepository.SaveChangesAsync();
                var getEmployeeRepsonseViewModel = new GetEmployeeRepsonseViewModel(newEmployee);
                return new ServiceResponse<GetEmployeeRepsonseViewModel>(getEmployeeRepsonseViewModel);
            }
            catch(Exception ex)
            {
                return new ServiceResponse<GetEmployeeRepsonseViewModel>(data: null, "Something Went Wrong");
            }
        }

        public async Task<ServiceResponse<List<GetEmployeeRepsonseViewModel>>> GetAllEmployees()
        { 

           try
            {
                var Employees = await _employeeRepository.GetAllEmployeesAsync();
                var data = Employees.Select(employee => new GetEmployeeRepsonseViewModel(employee)).ToList();   

                return new ServiceResponse<List<GetEmployeeRepsonseViewModel>>(data);
                    
            }
            catch (Exception ex)
            {
                return new ServiceResponse<List<GetEmployeeRepsonseViewModel>>(null, "Something Went Wrong");
            }
        }

        public async Task<ServiceResponse<GetEmployeeRepsonseViewModel>> GetEmployeeById(int Id)
        {
            try
            {
                var employee = await _employeeRepository.GetEmployeeByIdAsync(Id);
                if (employee == null)
                {
                    return new ServiceResponse<GetEmployeeRepsonseViewModel>(null, "Record not found");
                }
                var getEmployeeResponseViewModel = new GetEmployeeRepsonseViewModel(employee);
                return new ServiceResponse<GetEmployeeRepsonseViewModel>(getEmployeeResponseViewModel);
            }
            catch(Exception ex)
            {
                return new ServiceResponse<GetEmployeeRepsonseViewModel>(null, "Something Went Wrong");
            }
        }
    }
}
