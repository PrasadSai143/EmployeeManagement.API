using System;
using System.Collections.Generic;
namespace EmployeeManagement.Models
{
   
    public partial class EmpSalary
    {
        public System.Guid ID { get; set; }
        public System.Guid EMPID { get; set; }
        public bool EMPTYPE { get; set; }
        public double SALARY { get; set; }
        public bool ISACTIVE { get; set; }
        public Nullable<System.DateTime> CREATEDON { get; set; }
        public string CREATEDBY { get; set; }
        public string UPDATEDBY { get; set; }
        public Nullable<System.DateTime> UPDATEDON { get; set; }
    
        public virtual Employee Employee { get; set; }
    }
}
