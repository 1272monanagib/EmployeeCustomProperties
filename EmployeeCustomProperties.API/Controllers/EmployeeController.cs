using EmployeeCustomProperties.API.ControllerExtensions;
using EmployeeCustomProperties.Services.Interfaces;
using EmployeeCustomProperties.Services.ViewModels.EmployeeService;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeCustomProperties.API.Controllers
{
    public class EmployeeController: BaseController
    {
        private readonly IEmployeeService _employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }
        [HttpPost("Add")]
        public async Task<ActionResult<GetEmployeeRepsonseViewModel>> AddEmployee([FromForm]AddEmployeeRequestViewModel addEmployeeRequestViewModel)
        {
            var response = await _employeeService.AddEmployee(addEmployeeRequestViewModel);
            return response.IsSuccess ? Ok(response.Data) : BadRequest(response.ErrorMessage);
        }
        [HttpGet("GetAll")]
        public async Task<ActionResult<List<GetEmployeeRepsonseViewModel>>> GetAllEmployees()
        {
            var response = await _employeeService.GetAllEmployees();
            return response.IsSuccess ? Ok(response.Data) : BadRequest(response.ErrorMessage);
        }
        [HttpGet("{Id:int}")]
        public async Task<ActionResult<GetEmployeeRepsonseViewModel>> GetEmployeeById([FromRoute]int Id)
        {
            var response = await _employeeService.GetEmployeeById(Id);
            return response.IsSuccess ? Ok(response.Data) : BadRequest(response.ErrorMessage);
        }
    }
}
