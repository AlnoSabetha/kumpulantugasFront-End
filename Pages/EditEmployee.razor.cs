using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fe_Blazor.Models;
using Fe_Blazor.Services;
using Microsoft.AspNetCore.Components;

namespace Fe_Blazor.Pages
{
    public partial class EditEmployee
    {
        public Employee Employee { get; set; } = new Employee();

        [Inject]
        public IEmployeeService EmployeeService { get; set;}

        [Inject]
        public IDepartmentService DepartmentService { get; set; }
        public List<Department> Departments { get; set; } = new Department();

        [Parameter]
        public string Id { get; set; }

        protected async override Task OnInitializedAsync()
        {
            Employee = await EmployeeService.GetById(int.Parse(Id));
            Employee = (await DepartmentService.GetAll(int.Parse(Id)).ToList();
        }
    }
}