using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Fe_Blazor.Models;

namespace Fe_Blazor.Services
{
    public class EmployeeService : IEmployeeService
 {
        private HttpClient _httpClient;

        public EmployeeService()
        {
        }

        public EmployeeService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<IEnumerable<Employee>> GetAll()
        {
            var results = await _httpClient.GetFromJsonAsync<IEnumerable<Employee>>("api/Employees");
            return results;
        }

        public async Task<Employee> GetById(int id)
        {
            var result = await _httpClient.GetFromJsonAsync<Employee>($"api/Employees/{id}");
            return result;
        }

        public async Task<Employee> Add(Employee obj){
            var response = await _httpClient.PostAsJsonAsync($"api/Employees",obj);
            if(response.IsSuccessStatusCode){
                return await JsonSerializer.DeserializeAsync<Employee>(await response.Content.ReadAsStreamAsync());
            }
            else{
                throw new Exception("gagal tambah data employee");
            }
        }
    }
}
