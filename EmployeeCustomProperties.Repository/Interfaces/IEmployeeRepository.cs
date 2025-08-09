using EmployeeCustomProperties.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCustomProperties.Repository.Interfaces
{
    public interface IEmployeeRepository
    {
        Task AddEmployeeAsync(Employee employee);
        Task <List<Employee>> GetAllEmployeesAsync();
        Task<Employee> GetEmployeeByIdAsync(int id);
        Task<bool> SaveChangesAsync();
    }
}
