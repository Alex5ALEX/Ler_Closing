using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using WarehousClosingClient.Models;

namespace WarehousClosingClient.Controllers;

public class ProductController
{

    private HttpClient httpClient;
    private readonly Uri url;

    public ProductController(HttpClient htttpClient)
    {
        this.httpClient = htttpClient;
        url = new Uri("https://localhost:7262/api/product");
    }


    public async Task<List<Product>> GetAllProductsAsync()
    {
        List<Product> products = new List<Product>(); // Initialize the list of customers
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

        foreach (var product in contentArray)
        {
            products.Add(new Product()
            {
                Id = Guid.Parse(product["id"].ToString()),
                Name = product["name"].ToString(),
                Price = decimal.Parse(product["price"].ToString())
            });
        }

        return products; 
    }



    public async Task<Product> GetProductById(Guid Id)
    {
        var response = await httpClient.GetAsync($"{url}/{Id}");


        if (!response.IsSuccessStatusCode)
        {
            return new Product();
            //throw new Exception($"Ошибка при получении данных: {response.StatusCode}");
        }

        var data = await response.Content.ReadAsStringAsync();

        var content = JsonConvert.DeserializeObject<Product>(data);

        return content;



    }





    public Task<HttpResponseMessage> PostProduct(Product product)
    {
        return httpClient.PostAsJsonAsync(url, product);
    }


    public Task<HttpResponseMessage> PutProduct(Product product)
    {
        return httpClient.PutAsJsonAsync($"{url}/{product.Id.ToString()}", product);
    }


    public Task<HttpResponseMessage> DelProduct(Product product)
    {
        return httpClient.DeleteAsync($"{url}/{product.Id.ToString()}");
    }


}
