using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using WarehousClosingClient.Models;

namespace WarehousClosingClient.Controllers;

public class SupplyCompaundController
{
    private HttpClient httpClient;
    private readonly Uri url;

    public SupplyCompaundController(HttpClient htttpClient)
    {
        this.httpClient = htttpClient;
        url = new Uri("https://localhost:7262/api/supply_compaund");

    }


    /*s
    public async Task<List<OrderCompaund>> GetAllOrderCompaundsAsync()
    {
        List<OrderCompaund> compaund = new List<OrderCompaund>(); // Initialize the list of customers
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
            compaund.Add(new OrderCompaund()
            {
                Quantity = int.Parse(token["quantity"].ToString()),
                Id_Order = Guid.Parse(token["id_Order"].ToString()),
                Id_Product = Guid.Parse(token["id_Product"].ToString())

            });
        }

        return compaund;
    }
    */


    public async Task<List<SupplyCompaund>> GetSupplyCompaundByIdSupply(Guid Id)
    {
        List<SupplyCompaund> compaund = new List<SupplyCompaund>();
        string content;

        try
        {
            var response = await httpClient.GetAsync(url + $"/by_supply/{Id.ToString()}");

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
            compaund.Add(new SupplyCompaund()
            {
                Id_Supply = Guid.Parse(token["id_Supply"].ToString()),
                Quantity = int.Parse(token["quantity"].ToString()),
                Id_Product = Guid.Parse(token["id_Product"].ToString())
            });
        }

        return compaund;
    }


    public async Task<List<SupplyCompaund>> GetSupplyCompaundByIdProduct(Guid Id)
    {
        List<SupplyCompaund> compaund = new List<SupplyCompaund>();
        string content;

        try
        {
            var response = await httpClient.GetAsync(url + $"/by_product/{Id}");

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
            compaund.Add(new SupplyCompaund()
            {
                Id_Supply = Guid.Parse(token["id_Supply"].ToString()),
                Quantity = int.Parse(token["quantity"].ToString()),
                Id_Product = Guid.Parse(token["id_Product"].ToString())
            });
        }

        return compaund;
    }





    public async Task<HttpResponseMessage> PostSupplyCompaund(SupplyCompaund supply)
    {
        return await httpClient.PostAsJsonAsync(url, supply);
    }


    public Task<HttpResponseMessage> PutSupplyCompaund(SupplyCompaund supply)
    {
        return httpClient.PutAsJsonAsync($"{url}/{supply.Id_Supply.ToString()}/{supply.Id_Product.ToString()}", supply);
    }


    public Task<HttpResponseMessage> DelSupplyCompaund(SupplyCompaund supply)
    {
        return httpClient.DeleteAsync($"{url}/{supply.Id_Supply.ToString()}/{supply.Id_Product.ToString()}");
    }


}
