using System;
using System.Collections.Generic;

namespace EmployeeManagement.Models
{
   
    
    public partial class Department
    {
        public System.Guid ID { get; set; }
        public string NAME { get; set; }
        public string CODE { get; set; }
        public bool ISACTIVE { get; set; }
        public Nullable<System.DateTime> CREATEDON { get; set; }
        public Nullable<System.DateTime> CREATEDBY { get; set; }
        public Nullable<System.DateTime> UPDATEDON { get; set; }
        public string UPDATEDBY { get; set; }
    }
}
