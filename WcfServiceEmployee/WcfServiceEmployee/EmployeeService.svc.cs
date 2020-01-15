using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceEmployee
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "EmployeeService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select EmployeeService.svc or EmployeeService.svc.cs at the Solution Explorer and start debugging.
    public class EmployeeService : IEmployeeService
    {
        private static List<Employee> list = new List<Employee>();
        private static int count = 1;
        public Employee AddEmployee(Employee employee)
        {
            employee.EmployeeId = count;
            employee.Status = StatusType.Active;
            list.Add(employee);
            count++;
            return employee;
        }

        public List<Employee> GetList(int status)
        {
            if (status == 1)
            {
                return list.FindAll(l => l.Status == StatusType.Active);
            } else
            return list.FindAll(l => l.Status == StatusType.Deacive);
        }

        public bool DeleteEmployee(int id) { 
        
            var employee = list.Find(l => l.EmployeeId == id);
            if (employee != null)
            {
                employee.Status = StatusType.Deacive;
                return true;
            }

            return false;
        }
    }
}
