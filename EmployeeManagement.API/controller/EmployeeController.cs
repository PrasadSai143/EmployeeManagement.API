using EmployeeManagement;
using EmployeeManagement.DAL.Interfaces;
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
        private readonly IEmployeeDAL _employeeService;

        public EmployeeController(IEmployeeDAL employeeService)
        {
            this._employeeService = employeeService;
        }

        [HttpGet("getEmployees/{gender}")]
        public IActionResult GetEmployees(string gender)
        {
            var data = _employeeService.GetEmployees(gender);
            return Ok(data);
        }

        [HttpGet("getEmployeeById/{id}")]
        public IActionResult GetEmployeeById(Guid id)
        {
            var data = _employeeService.GetEmployee(id);
            return Ok(data);
        }

        [HttpPost("saveemployee")]
        public IActionResult SaveEmployee(Employee employee)
        {
            var emp = _employeeService.SaveEmployee(employee);
            return Ok(emp); 
        }

        [HttpGet("getGenderByCount")]
        public IActionResult GetGenderByCount()
        {
            var emp = _employeeService.GetGenderCount();
            return Ok(emp);
        }  
        
        [HttpGet("getYearCount")]
        public IActionResult GetYearCount()
        {
            var emp = _employeeService.GetYearCount();
            return Ok(emp);
        }

        [HttpGet("getDepartments")]
        public IActionResult GetDepartments()
        {
            var departments = _employeeService.GetDepartments();
            return Ok(departments);
        }

        [HttpGet("getAllEmployees")]
        public IActionResult GetEmployees()
        {
            var employees = _employeeService.GetEmployees();
            return Ok(employees);
        }
    }
}
