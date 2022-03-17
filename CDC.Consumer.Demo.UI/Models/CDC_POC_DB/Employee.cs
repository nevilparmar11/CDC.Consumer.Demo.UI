using System;
using System.Collections.Generic;

#nullable disable

namespace CDC.Consumer.Demo.UI.Models.CDC_POC_DB
{
    public partial class Employee
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public DateTime? Date { get; set; }
        public Guid? GlobalEmployeeId { get; set; }
    }
}
