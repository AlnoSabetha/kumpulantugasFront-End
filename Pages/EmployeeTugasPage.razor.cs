using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fe_Blazor.Models;
using Fe_Blazor.Services;
using Microsoft.AspNetCore.Components;

namespace Fe_Blazor.Pages
{
    public partial class EmployeeTugasPage
      {
        public IEnumerable<Employee> Employees { get; set; }

        [Inject]
        public IEmployeeService EmployeeService { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Employees = (await EmployeeService.GetAll()).ToList();
        }
    }
}