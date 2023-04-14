using EmployeeManagement.Models;
using EmployeeManagement.Repository.Interfaces;
using EmployeeManagement.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagement.Services.Implementation
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            this._employeeRepository = employeeRepository;
        }
        public Employee DeleteEmployee(Guid id)
        {
            throw new NotImplementedException();
        }

        public Employee GetEmployee(Guid empId)
        {
            return _employeeRepository.GetEmployee(empId);
        }

        public IEnumerable<Employee> GetEmployees()
        {
            return this._employeeRepository.GetEmployees();
        }

        public Employee SaveEmployee(Employee employee)
        {
            throw new NotImplementedException();
        }

        public Employee UpdateEmployee(Employee employee)
        {
            throw new NotImplementedException();
        }
    }
}
