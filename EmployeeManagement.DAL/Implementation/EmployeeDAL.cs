using EmployeeManagement.Context;
using EmployeeManagement.DAL.Interfaces;
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
        public Employee DeleteEmployee(Guid id)
        {
            throw new NotImplementedException();
        }

        public Employee GetEmployee(Guid empId)
        {
            return _employeeDBContext.Employees.Find(empId);
        }

        public IEnumerable<Employee> GetEmployees(string gender)
        {
            return this._employeeDBContext.Employees.Where(x => x.Gender == gender).ToList();
        }

        public List<GenderCount> GetGenderCount()
        {
            var query = _employeeDBContext.Employees.GroupBy(x => x.Gender).Select(x => new GenderCount { Gender = x.Key, Count = x.Count() }).ToList();
            return query;
        }

        public dynamic GetYearCount()
        {
            var query = _employeeDBContext.Employees.GroupBy(x => x.DateOfBirth.Year).Select(x => new { Year = x.Key, Count = x.Count() }).ToList();
            return query;
        }

        public Employee SaveEmployee(Employee employee)
        {
            _employeeDBContext.Employees.Add(employee);
            _employeeDBContext.SaveChanges();
            return employee;
        }

        public Employee UpdateEmployee(Employee employee)
        {
            throw new NotImplementedException();
        }

        public List<Department> GetDepartments()
        {
           return _employeeDBContext.Departments.ToList();
        }

        public IEnumerable<Employee> GetEmployees()
        {
            return _employeeDBContext.Employees.ToList();
        }
    }
}
