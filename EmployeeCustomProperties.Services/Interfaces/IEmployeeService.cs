using EmployeeCustomProperties.Services.ViewModels.EmployeeService;
using EmployeeCustomProperties.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCustomProperties.Services.Interfaces
{
    public interface IEmployeeService
    {
        Task<ServiceResponse<GetEmployeeRepsonseViewModel>> AddEmployee(AddEmployeeRequestViewModel addEmployeeRequestViewModel);
        Task<ServiceResponse<List<GetEmployeeRepsonseViewModel>>> GetAllEmployees();
        Task<ServiceResponse<GetEmployeeRepsonseViewModel>> GetEmployeeById(int Id);
    }
}
