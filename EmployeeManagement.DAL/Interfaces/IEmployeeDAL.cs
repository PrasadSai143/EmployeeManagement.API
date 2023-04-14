using EmployeeManagement.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagement.DAL.Interfaces
{
    public interface IEmployeeDAL
    {
        public IEnumerable<Employee> GetEmployees();
        public Employee GetEmployee(Guid empId);
        public Employee SaveEmployee(Employee employee);
        public Employee UpdateEmployee(Employee employee);
        public Employee DeleteEmployee(Guid id);
    }
}
