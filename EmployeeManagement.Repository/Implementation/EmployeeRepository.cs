using EmployeeManagement.DAL.Interfaces;
using EmployeeManagement.Models;
using EmployeeManagement.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagement.Repository.Implementation
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly IEmployeeDAL _employeeDAL;

        public EmployeeRepository(IEmployeeDAL employeeDAL)
        {
            this._employeeDAL = employeeDAL;
        }
        public Employee DeleteEmployee(Guid id)
        {
            throw new NotImplementedException();
        }

        public Employee GetEmployee(Guid empId)
        {
            return _employeeDAL.GetEmployee(empId);
        }

        public IEnumerable<Employee> GetEmployees()
        {
            return this._employeeDAL.GetEmployees();
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
