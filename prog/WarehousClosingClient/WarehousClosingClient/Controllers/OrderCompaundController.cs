using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using WarehousClosingClient.Models;

namespace WarehousClosingClient.Controllers;

public class OrderCompaundController
{
    
    private HttpClient httpClient;
    private readonly Uri url;

    public OrderCompaundController(HttpClient htttpClient)
    {
        this.httpClient = htttpClient;
        url = new Uri("https://localhost:7262/api/order_compaund");

    }



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



    public async Task<List<OrderCompaund>> GetOrderCompaundByIdOrder(Guid Id)
    {
        List<OrderCompaund> compaund = new List<OrderCompaund>();
        string content;

        try
        {
            var response = await httpClient.GetAsync(url + $"/by_order/{Id}");

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


    public async Task<List<OrderCompaund>> GetOrderCompaundByIdProduct(Guid Id)
    {
        List<OrderCompaund> compaund = new List<OrderCompaund>();
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
            compaund.Add(new OrderCompaund()
            {
                Quantity = int.Parse(token["quantity"].ToString()),
                Id_Order = Guid.Parse(token["id_Order"].ToString()),
                Id_Product = Guid.Parse(token["id_Product"].ToString())

            });
        }

        return compaund;
    }




    
    public async Task<HttpResponseMessage> PostOrderCompaund(OrderCompaund order)
    {
        return await httpClient.PostAsJsonAsync(url, order);
    }

    
    public Task<HttpResponseMessage> PutOrderCompaund(OrderCompaund order)
    {
        return httpClient.PutAsJsonAsync(url, order);
    }

    
    public Task<HttpResponseMessage> DelOrderCompaund(OrderCompaund order)
    {
        return httpClient.DeleteAsync($"{url}/{order.Id_Order.ToString()}/{order.Id_Product.ToString()}");
    }
}
