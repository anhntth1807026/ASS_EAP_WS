using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfServiceEmployee
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public double Salary { get; set; }
        public string Department { get; set; }
        public StatusType Status { get; set; }
    }
    public enum StatusType
    {
        Active = 1, Deacive = 0
    }
}