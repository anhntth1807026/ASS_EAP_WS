using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceEmployee
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IEmployeeService" in both code and config file together.
    [ServiceContract]
    public interface IEmployeeService
    {
        [OperationContract]
        Employee AddEmployee(Employee employee);

        [OperationContract]
        List<Employee> GetList(int status);

        [OperationContract]
        Boolean DeleteEmployee(int id);
    }
}
