using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace EmployeeService.Controllers
{   [System.Web.Http.Authorize]
    public class EmployeeController : ApiController
    {
        // GET: Employee
        public IEnumerable<Employee> Get()
        {using (EMPLOYEEDBEntities entities = new EMPLOYEEDBEntities()) { return entities.Employees.ToList(); }
                
        }
    }
}