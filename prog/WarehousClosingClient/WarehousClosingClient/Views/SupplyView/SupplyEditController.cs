using Newtonsoft.Json.Linq;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using WarehousClosingClient.Models;
namespace WarehousClosingClient.Views.SupplyView;

public partial class SupplyEditController : UserControl
{
    private SupplyControl mainController;
    private Supply supply;

    private List<SupplyCompaund> supplyCompaunds { get; set; } = [];
    private List<ProductAddRowControl> productRow { get; set; } = [];



    public SupplyEditController(SupplyControl mainController, Supply supply)
    {
        this.mainController = mainController;
        this.supply = supply;

        InitializeComponent();
        InitializeData();


        buttonBack.Click += Back;
        buttonEdit.Click += Edit;
        buttonDelete.Click += Delete;
    }




    private void Back(object? sender, EventArgs e)
    {
        mainController.HideActionGroupBox();
    }


    private async void InitializeData()
    {
        textBoxId.Text = supply.Id.ToString();
        textBoxDate.Text =  supply.Date.ToString("dd MM yyyy");
        textBoxPrice.Text = supply.Price.ToString();
        textBoxProvider.Text = supply.Id_Provider.ToString();


        supplyCompaunds = await mainController.supplyCompaundController.GetSupplyCompaundByIdSupply(supply.Id);

        foreach (var item in supplyCompaunds)
        {
            Product token = await mainController.productController.GetProductById(item.Id_Product);
            
            if(token.Id == Guid.Empty) { continue; }

            var temp = new ProductAddRowControl(token);
            temp.SetQuantity(item.Quantity);
            productRow.Add(temp);
            flowLayoutPanel1.Controls.Add(temp);
        }
    }

       

    private async void Edit(object? sender, EventArgs e)
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

        if (!Guid.TryParse(textBoxProvider.Text, out idProvider))
        {
            MessageBox.Show("id введен ен верно");
            return;
        }

        if (!await mainController.providerController.providerExist(idProvider))
        {
            MessageBox.Show("Поставщика не существует");
            return;
        }


        decimal price = 0;

        if (!decimal.TryParse(textBoxPrice.Text, out price))
        {
            MessageBox.Show("Цена введена не корректно.");
            return;
        }


        
        if (await editSupply(date, idProvider, price))
        {
            textBoxDate.Text = string.Empty;
            textBoxPrice.Text = string.Empty;
            textBoxProvider.Text = string.Empty;

            InitializeData();
            mainController.UpdateData();
        }
    }

    
    private async Task<bool> editSupply(DateTime date, Guid idProvider, decimal price)
    {
        supply.Date = date;
        supply.Id_Provider = idProvider;
        supply.Price = price;

        
        var response = await mainController.supplyController.PutSupply(supply);

        foreach (var item in productRow)//List<ProductAddRowControl>
        { 

            foreach(var temp in supplyCompaunds)//List<SupplyCompaund>
            {

                if(item.product.Id == temp.Id_Product)
                {
                    
                    if(item.GetQuantity() != temp.Quantity)
                    {
                        temp.Quantity = item.GetQuantity();
                        mainController.supplyCompaundController.PutSupplyCompaund(temp);
                    }
                }
            }
           
        }

        return true;//вернуть если успешно
    }


    private void Delete(object? sender, EventArgs e)
    {
        DialogResult result = MessageBox.Show("Are you sure want to delete?", "", MessageBoxButtons.YesNo);

        if (result == DialogResult.No){return;}


        var response = mainController.supplyController.DelSupply(supply);

        foreach (var item in supplyCompaunds)
        {
            mainController.supplyCompaundController.DelSupplyCompaund(item);
        }


        if (response.Result.IsSuccessStatusCode)
        {
            mainController.UpdateData();
            Back(sender, e);
        }
    }
    
}
