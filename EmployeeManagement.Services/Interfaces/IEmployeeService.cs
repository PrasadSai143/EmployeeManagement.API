using EmployeeManagement.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagement.Services.Interfaces
{
    public interface IEmployeeService
    {
        public IEnumerable<Employee> GetEmployees();
        public Employee GetEmployee(int empId);
        public Employee SaveEmployee(Employee employee);
        public Employee UpdateEmployee(Employee employee);
        public Employee DeleteEmployee(int id);
    }
}
