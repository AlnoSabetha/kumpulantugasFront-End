using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fe_Blazor.Models;
using Fe_Blazor.Services;
using Microsoft.AspNetCore.Components;

namespace Fe_Blazor.Pages
{
    public partial class DepartmentPage
      {
        public List<Department> Departments { get; set; } = new List<Department>();

        [Inject]
        public IDepartmentService DepartmentService { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Departments = (await DepartmentService.GetAll()).ToList();
        }
    }
}