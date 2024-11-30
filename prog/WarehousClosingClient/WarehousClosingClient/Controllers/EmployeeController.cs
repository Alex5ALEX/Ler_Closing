using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.DirectoryServices.ActiveDirectory;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using WarehousClosingClient.Models;

namespace WarehousClosingClient.Controllers;

public class EmployeeController
{
    private HttpClient httpClient;
    private readonly Uri url;

    public EmployeeController(HttpClient htttpClient)
    {
        this.httpClient = htttpClient;
        url = new Uri("https://localhost:7262/api/employee");

    }


    public async Task<List<Employee>> GetAllEmployersAsync()
    {
        List<Employee> employers = new List<Employee>(); // Initialize the list of customers
        string content;

        try
        {
            var response = await httpClient.GetAsync(url);

            response.EnsureSuccessStatusCode(); // Check for a successful status

            content = await response.Content.ReadAsStringAsync();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Ошибка: {ex.Message}");
            return null; // Return null on error
        }

        var contentArray = JArray.Parse(content);

        foreach (var employee in contentArray)
        {
            employers.Add(new Employee()
            {
                Id = Guid.Parse(employee["id"].ToString()),
                Name = employee["name"].ToString(),
                Surname = employee["surname"].ToString(),
                JobTitle = employee["jobTitle"].ToString(),
                Phone = employee["phone"].ToString(),
                Email = employee["email"].ToString(),
                Address = employee["address"].ToString()
            });
        }

        return employers; // Return the populated list of customers
    }



    public async Task<Employee> GetEmployeeById(Guid Id)
    {
        var response = await httpClient.GetAsync(url + $"/{Id.ToString()}");


        if (!response.IsSuccessStatusCode)
        {
            return new Employee();
            //throw new Exception($"Ошибка при получении данных: {response.StatusCode}");
        }

        var data = await response.Content.ReadAsStringAsync();

        var content = JsonConvert.DeserializeObject<Employee>(data);

        return content;
    }





    public Task<HttpResponseMessage> PostEmployee(Employee employee)
    {
        return httpClient.PostAsJsonAsync(url, employee);
    }


    public Task<HttpResponseMessage> PutEmployee(Employee employee)
    {
        return httpClient.PutAsJsonAsync($"{url}/{employee.Id.ToString()}", employee);
    }


    public Task<HttpResponseMessage> DelEmployee(Employee employee)
    {
        return httpClient.DeleteAsync($"{url}/{employee.Id.ToString()}");
    }


    public async Task<bool> employeeExist(Guid Id)
    {
        var response = await GetEmployeeById(Id);

        if (response.Id == Guid.Empty)
        {
            return false;
        }
        else
        {
            return true;
        }

    }


    



}
