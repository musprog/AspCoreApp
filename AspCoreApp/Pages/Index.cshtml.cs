using AspCoreApp.Services;
using AspCoreApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspCoreApp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger, EmployeeService eService)
        {
            _logger = logger;
            EmployeeServiceObj = eService;
        }

        public EmployeeService EmployeeServiceObj { get; }
        public IEnumerable<Employee> Employees { get; private set; }
        public void OnGet() => Employees = EmployeeServiceObj.GetEmployees();
    }
}
