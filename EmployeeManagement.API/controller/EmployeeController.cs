using EmployeeManagement.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManagement.API.controller
{
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            this._employeeService = employeeService;
        }

        [HttpGet("getEmployees")]
        public IActionResult GetEmployees()
        {
            var data = _employeeService.GetEmployees();
            return Ok(data);
        }

        [HttpGet("getEmployeeById/{id}")]
        public IActionResult GetEmployeeById(Guid id)
        {
            var data = _employeeService.GetEmployee(id);
            return Ok(data);
        }
    }
}
