using EmployeeManagement.Context;
using EmployeeManagement.DAL.Interfaces;
using EmployeeManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EmployeeManagement.DAL.Implementation
{
    public class EmployeeDAL : IEmployeeDAL
    {
        private readonly EmployeeDBContext _employeeDBContext; 
        public EmployeeDAL(EmployeeDBContext employeeDBContext)
        {
            this._employeeDBContext = employeeDBContext;
        }
        public Employee DeleteEmployee(int id)
        {
            throw new NotImplementedException();
        }

        public Employee GetEmployee(int empId)
        {
            return _employeeDBContext.Employees.Find(empId);
        }

        public IEnumerable<Employee> GetEmployees()
        {
            return this._employeeDBContext.Employees.ToList();
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
