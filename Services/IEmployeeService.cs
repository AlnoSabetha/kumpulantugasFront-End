using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fe_Blazor.Models;

namespace Fe_Blazor.Services
{
    public interface IEmployeeService
    {
         Task<IEnumerable<Employee>> GetAll();
         Task<Employee> GetById(int id);
    }
}