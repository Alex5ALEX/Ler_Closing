using Newtonsoft.Json.Linq;
using System;
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
namespace WarehousClosingClient.Views.ProductView;

public partial class ProductEditController : UserControl
{
    private ProductControl mainController;
    private Product product;



    public ProductEditController(ProductControl mainController, Product product)
    {
        this.mainController = mainController;
        this.product = product;

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
        richTextBoxId.Text = product.Id.ToString();
        textBoxName.Text = product.Name;
        textBoxPrice.Text = product.Price.ToString();
    }



    private void Edit(object? sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(textBoxName.Text) ||
        string.IsNullOrWhiteSpace(textBoxPrice.Text))
        {
            MessageBox.Show("Пожалуйста, заполните все поля.");
            return;
        }

        decimal price;

        if(!decimal.TryParse(textBoxPrice.Text, out price))
        {
            MessageBox.Show("Цена введена не корректно.");
            return;
        }


        product.Name = textBoxName.Text;
        product.Price = price;


        var response = mainController.productController.PutProduct(product);

        if (response.Result.IsSuccessStatusCode)
        {
            mainController.UpdateData();
        }
    }


    private void Delete(object? sender, EventArgs e)
    {
        DialogResult result = MessageBox.Show("Are you sure want to delete?", "", MessageBoxButtons.YesNo);

        if (result == DialogResult.No) { return; }


        var response = mainController.productController.DelProduct(product);

        if (response.Result.IsSuccessStatusCode)
        {
            mainController.UpdateData();
            Back(sender, e);
        }
    }


}
