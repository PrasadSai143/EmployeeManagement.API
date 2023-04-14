using System;
using System.Collections.Generic;

namespace EmployeeManagement.Models
{
   
    public partial class Address
    {
        public System.Guid ID { get; set; }
        public System.Guid EMPID { get; set; }
        public string HouseNo { get; set; }
        public string StreetName { get; set; }
        public string VillageName { get; set; }
        public string CityName { get; set; }
        public string District { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string PinCode { get; set; }
    }
}
