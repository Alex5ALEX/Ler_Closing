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

namespace WarehousClosingClient.Views.SupplyView;

public partial class SupplyAddController : UserControl
{

    private SupplyControl mainController;
    private List<ProductAddRowControl> productRow { get; set; } = [];


    public SupplyAddController(SupplyControl mainController)
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
            var token = new ProductAddRowControl(item);
            productRow.Add(token);
            flowLayoutPanel1.Controls.Add(token);
        }
    }

  

    private async void AddItem(object? sender, EventArgs e)
    {
        //проверка что пользователь ввел все поля
        if (string.IsNullOrWhiteSpace(textBoxDate.Text) ||
        string.IsNullOrWhiteSpace(textBoxPrice.Text) ||
        string.IsNullOrWhiteSpace(textBoxProvider.Text))
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



        Guid idProvider = Guid.Empty;

        if(!Guid.TryParse(textBoxProvider.Text, out idProvider))
        {
            MessageBox.Show("id введен ен верно");
            return;
        }
        
        if (! await mainController.providerController.providerExist(idProvider))
        {
            MessageBox.Show("Поставщика не существует");
            return;
        }


        decimal price = 0;
        
        if (! decimal.TryParse(textBoxPrice.Text, out price))
        {
            MessageBox.Show("Цена введена не корректно.");
            return;
        }



        if (await createSupply(date, idProvider, price))
        {
            textBoxDate.Text = string.Empty;
            textBoxPrice.Text = string.Empty;
            textBoxProvider.Text = string.Empty;

            InitializeData();
            mainController.UpdateData();
        }
    }


    
    private async Task<bool> createSupply(DateTime date, Guid idProvider, decimal price)
    {
        Supply supply = new Supply() 
        {
        Id = Guid.NewGuid(),
        Date = date,
        Price = price,
        Id_Provider = idProvider
        };


        var response = await mainController.supplyController.PostSupply(supply);

        if (!response.IsSuccessStatusCode)
        {
            return false;
        }

        foreach(var item in productRow)
        {
            if(item.GetQuantity() > 0)
            {
                SupplyCompaund compaund = new SupplyCompaund()
                {
                    Id_Supply = supply.Id,
                    Id_Product = item.product.Id,
                    Quantity = item.GetQuantity()
                };

                
                var responseCompaund = await mainController.supplyCompaundController.PostSupplyCompaund(compaund);

                if (responseCompaund.IsSuccessStatusCode) { continue; }
                
            }
        }


        return true;//вернуть если успешно
    }






}
