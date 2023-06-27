using EmployeeManagement.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagement.DAL.Interfaces
{
    public interface IEmployeeDAL
    {
        IEnumerable<Employee> GetEmployees(string g);
        IEnumerable<Employee> GetEmployees();
        Employee GetEmployee(Guid empId);
        Employee SaveEmployee(Employee employee);
        Employee UpdateEmployee(Employee employee);
        Employee DeleteEmployee(Guid id);
        List<GenderCount> GetGenderCount();
        dynamic GetYearCount();
        List<Department> GetDepartments();
    } 
}
