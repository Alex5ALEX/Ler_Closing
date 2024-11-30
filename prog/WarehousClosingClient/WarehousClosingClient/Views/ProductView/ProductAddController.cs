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

namespace WarehousClosingClient.Views.ProductView;

public partial class ProductAddController : UserControl
{
    private ProductControl mainController;

    public ProductAddController(ProductControl mainController)
    {
        this.mainController = mainController;

        InitializeComponent();

        buttonBack.Click += Back;
        buttonAdd.Click += AddItem;
    }

    private void Back(object? sender, EventArgs e)
    {
        mainController.HideActionGroupBox();
    }



    private void AddItem(object? sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(textBoxName.Text) ||
        string.IsNullOrWhiteSpace(textBoxPrice.Text))
        {
            MessageBox.Show("Пожалуйста, заполните все поля.");
            return;
        }

        
        decimal price = 0;

        if(!decimal.TryParse(textBoxPrice.Text, out price))
        {
            MessageBox.Show("Цена введена не корректно.");
            return;
        }


        Product product = new Product()
        {
            Name = textBoxName.Text,
            Price = price
        };


        var response = mainController.productController.PostProduct(product);


        textBoxPrice.Text = "";
        textBoxName.Text = "";


        if (response.Result.IsSuccessStatusCode)
        {
            mainController.UpdateData();
        }

        //throw new NotImplementedException();
    }


}
