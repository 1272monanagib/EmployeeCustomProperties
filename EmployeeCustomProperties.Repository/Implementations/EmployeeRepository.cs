using EmployeeCustomProperties.Domain;
using EmployeeCustomProperties.Repository.Context;
using EmployeeCustomProperties.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCustomProperties.Repository.Implementations
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly AppDbContext _context;

        public EmployeeRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task AddEmployeeAsync(Employee employee)
        {
            await _context.Employees.AddAsync(employee);
           
        }

        public async Task<List<Employee>> GetAllEmployeesAsync()
        {
            return await _context.Employees.Include(e => e.CustomProperties)
                .ThenInclude(cp => cp.CustomPropertyDropdowns)
                .ToListAsync();
        }

        public async Task<Employee> GetEmployeeByIdAsync(int id)
        {
            return await _context.Employees.Include(e => e.CustomProperties)
                .ThenInclude(cp => cp.CustomPropertyDropdowns)
                .FirstOrDefaultAsync(e => e.Id == id);
        }

        public async Task<bool> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync() > 0;   
        }
    }
}
