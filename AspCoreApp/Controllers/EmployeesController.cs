using AspCoreApp.Models;
using AspCoreApp.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspCoreApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        public EmployeesController(EmployeeService eService) =>
            EmployeeServiceObj = eService;

        public EmployeeService EmployeeServiceObj { get; }

        [HttpGet]
        public IEnumerable<Employee> Get() => EmployeeServiceObj.GetEmployees();
    }
}
