// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace AspCoreApp.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\musta\source\repos\AspCoreApp\AspCoreApp\Components\EmployeeList.razor"
using AspCoreApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\musta\source\repos\AspCoreApp\AspCoreApp\Components\EmployeeList.razor"
using AspCoreApp.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\musta\source\repos\AspCoreApp\AspCoreApp\Components\EmployeeList.razor"
using AspCoreApp.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\musta\source\repos\AspCoreApp\AspCoreApp\Components\EmployeeList.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
    public partial class EmployeeList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 65 "C:\Users\musta\source\repos\AspCoreApp\AspCoreApp\Components\EmployeeList.razor"
 
    Employee selectedEmployee;
    string selectedEmployeeId;

    void SelectEmployee(string employeeId)
    {
        selectedEmployeeId = employeeId;
        selectedEmployee = eService.GetEmployees().First(x => x.Id.ToString() == employeeId);
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private EmployeeService eService { get; set; }
    }
}
#pragma warning restore 1591
