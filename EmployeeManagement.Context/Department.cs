using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EmployeeManagement.Context
{
    public class Department
    {
        [Key]
        public long DeptId { get; set; }
        public string DeptName { get; set; }
    }
}