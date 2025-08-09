using EmployeeCustomProperties.Repository.Context;
using EmployeeCustomProperties.Repository.Implementations;
using EmployeeCustomProperties.Repository.Interfaces;
using EmployeeCustomProperties.Services.Implementations;
using EmployeeCustomProperties.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Runtime.CompilerServices;

namespace EmployeeCustomProperties.Services
{
    public static class RegisterApplicationService
    {
        public static void RegisterAppServices( this IServiceCollection serviceCollection , IConfiguration configuration)
        {
            RegisterDatabaseConnection(serviceCollection , configuration);
            RegisterServices(serviceCollection);
            RegisterRepositories(serviceCollection);
            
        }
        private static void RegisterDatabaseConnection(IServiceCollection serviceCollection , IConfiguration configuration)
        {
            serviceCollection.AddDbContext<AppDbContext>(options => { options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")); });
        }
        private static void RegisterServices(IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<IEmployeeService, EmployeeService>();
        }
        private static void RegisterRepositories(IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<IEmployeeRepository , EmployeeRepository>();
        }
    }
}
