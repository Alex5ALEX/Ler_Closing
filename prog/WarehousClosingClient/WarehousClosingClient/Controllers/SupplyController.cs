using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using WarehousClosingClient.Models;

namespace WarehousClosingClient.Controllers;

public class SupplyController
{
    private HttpClient httpClient;
    private readonly Uri url;

    public SupplyController(HttpClient htttpClient)
    {
        this.httpClient = htttpClient;
        url = new Uri("https://localhost:7262/api/supply");

    }

    public async Task<List<Supply>> GetAllSupplyAsync()
    {
        List<Supply> supply = new List<Supply>(); // Initialize the list of customers
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

        foreach (var token in contentArray)
        {
            supply.Add(new Supply()
            {
                Id = Guid.Parse(token["id"].ToString()),
                Date = DateTime.Parse(token["date"].ToString()),
                Price = decimal.Parse(token["price"].ToString()),
                Id_Provider = Guid.Parse(token["id_Provider"].ToString())
            });
        }

        return supply;
    }



    public async Task<string> GetSupplyById(Guid Id)
    {
        var response = await httpClient.GetAsync(url + $"/{Id}");

        //response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync();
    }



    public async Task<HttpResponseMessage> PostSupply(Supply supply)
    {
        return await httpClient.PostAsJsonAsync(url, supply);
    }


    public Task<HttpResponseMessage> PutSupply(Supply supply)
    {
        return httpClient.PutAsJsonAsync($"{url}/{supply.Id.ToString()}", supply);
    }


    public Task<HttpResponseMessage> DelSupply(Supply supply)
    {
        return httpClient.DeleteAsync($"{url}/{supply.Id.ToString()}");
    }


}
