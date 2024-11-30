using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;
using WarehousClosingClient.Models;
using WarehousClosingClient.Controllers;
using System.Windows.Forms.VisualStyles;
using System.Net.Http;
using System.Security.Policy;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Reflection.Metadata;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WarehousClosingClient.Views.OrderView;

public partial class OrderAddController : UserControl
{

    private OrderControl mainController;
    private List<OrderAddRowControl> productRow { get; set; } = [];


    public OrderAddController(OrderControl mainController)
    {
        this.mainController = mainController;

        InitializeComponent();
        InitializeData();
       

        buttonBack.Click += Back;
        buttonAdd.Click += AddItem;
    }

    private void Back(object? sender, EventArgs e)
    {
        mainController.HideActionGroupBox();
    }


    public async void InitializeData()
    {
        flowLayoutPanel1.Controls.Clear();

        var products = await mainController.productController.GetAllProductsAsync();

        foreach (var item in products)
        {
            var token = new OrderAddRowControl(item);
            productRow.Add(token);
            flowLayoutPanel1.Controls.Add(token);
        }

    }

  

    private async void AddItem(object? sender, EventArgs e)
    {
        //проверка что пользователь ввел все поля
        if (string.IsNullOrWhiteSpace(textBoxDate.Text) ||
        string.IsNullOrWhiteSpace(textBoxCustomer.Text) ||
        string.IsNullOrWhiteSpace(textBoxEmployee.Text))
        {
            MessageBox.Show("Пожалуйста, заполните все поля.");
            return;
        }


        //проверка на правильный ввод даты
        DateTime date = DateTime.Now;

        if (!DateTime.TryParseExact(textBoxDate.Text, "d M yyyy", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out date))
        {
            MessageBox.Show("Дата введена не верно. Введите в формате: dd MM yyyy");
            return;
        }


        //проверка на наличие клиента/ работника
        Guid idEmployee = Guid.Empty;
        Guid idCustomer = Guid.Empty;

        if(!Guid.TryParse(textBoxEmployee.Text, out idEmployee)||
            !Guid.TryParse(textBoxCustomer.Text, out idCustomer))
        {
            MessageBox.Show("id введен ен верно");
            return;
        }
        
        if (! await mainController.employeeController.employeeExist(idEmployee))
        {
            MessageBox.Show("Работника не существует");
            return;
        }
        
        if (! await mainController.customerController.customerExist(idCustomer))
        {
            MessageBox.Show("Клиента не существует");
            return;
        }



        if(await createOrder(date, idCustomer, idEmployee))
        {
            textBoxDate.Text = string.Empty;
            textBoxCustomer.Text = string.Empty;
            textBoxEmployee.Text = string.Empty;

            InitializeData();
            mainController.UpdateData();
        }
       

    }



    private async Task<bool> createOrder(DateTime date,Guid idCustomer, Guid idEmployee)
    {
        Order order = new Order()
        {
            Id = Guid.NewGuid(),
            Date = date,
            Id_Customer = idCustomer,
            Id_Employee = idEmployee,
        };


        Guid newOrderId = Guid.Empty;

        var response = await mainController.orderController.PostOrder(order);

        if (!response.IsSuccessStatusCode)
        {
            return false;
        }

        foreach(var item in productRow)
        {
            if(item.GetQuantity() > 0)
            {
                OrderCompaund compaund = new OrderCompaund()
                {
                    Id_Order = order.Id,
                    Id_Product = item.product.Id,
                    Quantity = item.GetQuantity()
                };

                
                var responseCompaund = await mainController.orderCompaundController.PostOrderCompaund(compaund);

                if (responseCompaund.IsSuccessStatusCode) { continue; }
                
            }
        }


        return true;//вернуть если успешно
    }






}
