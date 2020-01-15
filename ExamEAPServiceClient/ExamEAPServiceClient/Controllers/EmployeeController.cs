using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ExamEAPServiceClient.ServiceReference1;

namespace ExamEAPServiceClient.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        private static IEmployeeServices employeeService;
        public EmployeeController()
        {
            if (employeeService == null)
            {
                employeeService = new EmployeeServicesClient();
            }
        }
        // GET: Students
        public ActionResult Index(string department)
        {
            return View(employeeService.Search(department));
        }
        public ActionResult Create(Employee employee)
        {
            return View(employeeService.CreateEmployee(employee));
        }
    }
}