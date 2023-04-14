using System;
using System.Collections.Generic;

namespace EmployeeManagement.Models
{
    public partial class Employee
    {
        public Employee()
        {
            this.EmpSalaries = new HashSet<EmpSalary>();
        }
    
        public System.Guid ID { get; set; }
        public string NAME { get; set; }
        public bool GENDER { get; set; }
        public System.DateTime DATEOFBIRTH { get; set; }
        public string EMAIL { get; set; }
        public string MOBILE { get; set; }
        public bool MARITALSTATUS { get; set; }
        public bool ISACTIVE { get; set; }
        public Nullable<System.DateTime> CREATEDON { get; set; }
        public string CREATEDBY { get; set; }
        public string UPDATEDBY { get; set; }
        public Nullable<System.DateTime> UPDATEDON { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EmpSalary> EmpSalaries { get; set; }
    }
}
