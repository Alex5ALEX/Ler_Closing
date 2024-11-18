using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using Newtonsoft.Json.Linq;
using System.Security.Policy;
using System.Net.Http.Json;

namespace WarehousClosingClient.Views.CustomerView;

public partial class CustomerControl : UserControl
{

    private readonly HttpClient _httpClient;
    private CustomerAddController _customerAddController;

    public Guid _choisedId { get; set; }




    public CustomerControl()
    {
        _httpClient = new HttpClient();
        _httpClient = new Uri("https://localhost:7262/api/customer");
        _customerAddController = new CustomerAddController(this);


        InitializeComponent();
        UpdateData();


        buttonAddNew.Click += AddNewCustomer;
        buttonEdit.Click += EditCustomer;
    }



    /// <summary>
    /// вывод всех данных customer 
    /// </summary>
    public async void UpdateData()
    {
        flowLayoutPanel.Controls.Clear();

        var data = await GetDataFromApi();

        if (data != null && data != "[]") 
        {
            var customers = JArray.Parse(data); 

            foreach (var customer in customers)
            {

                //int ordersCount = customer["orders"].Count();

                
                var customerRow = new CustomerRowControl(
                    this,
                    customer["id"].ToString(),
                    customer["name"].ToString(),
                    customer["surname"].ToString(),
                    customer["phone"].ToString(),
                    customer["email"].ToString(),
                    customer["address"].ToString());
                

                flowLayoutPanel.Controls.Add(customerRow);
            }

        }
    }



    /// <summary>
    /// добавление нового customer
    /// </summary>
    private void AddNewCustomer(object? sender, EventArgs e)
    {
        flowLayoutPanel.Controls.Clear();
        flowLayoutPanel.Controls.Add(_customerAddController);
    }



    /// 
    /// редактирование customer
    /// 

    private void EditCustomer(object? sender, EventArgs e)
    {
        flowLayoutPanel.Controls.Clear();
        flowLayoutPanel.Controls.Add(new CustomerEditController(this));
    }








    ///
    /// методы для работы с бд
    ///

    private async Task<string> GetDataFromApi()
    {
        string apiUrl = "https://localhost:7262/api/customer"; // API URL

        try
        {
            var response = await _httpClient.GetAsync(apiUrl);
            response.EnsureSuccessStatusCode(); // Проверка на успешный статус

            var content = await response.Content.ReadAsStringAsync();


            return content; // Возвращаем содержимое ответа
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Ошибка: {ex.Message}");
            return null;
        }
    }


    private async Task<string> GetCustomerById(Guid Id)
    {
        string apiUrl = "https://localhost:7262/api/customer"; // API URL

        var response = await _httpClient.GetAsync(apiUrl + $"/{Id.ToString()}");

        if (response.IsSuccessStatusCode)
        {
            return await response.Content.ReadAsStringAsync(); // Возвращает данные клиента как строку
        }
        else if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
        {
            return "Customer not found."; // Обработка случая, когда клиент не найден
        }
        else
        {
            throw new Exception($"Error retrieving customer: {response.StatusCode}");
        }
    }


    public async Task<HttpResponseMessage> PostNewDataInApi(
        string name,
        string surname,
        string phone,
        string email,
        string addres
        )
    {
        string apiUrl = "https://localhost:7262/api/customer?"; // API URL



        var customerData = new
        {
            Name = name,
            Surname = surname,
            Phone = phone,
            Email = email,
            Address = addres
        };


        return await _httpClient.PostAsJsonAsync(apiUrl, customerData);

    }

}
