using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using WarehousClosingClient.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
namespace WarehousClosingClient.Views.ProductView;

public partial class ProductRowControl : UserControl
{
    private ProductControl mainController;
    private Product product;



    public ProductRowControl(ProductControl mainController, Product product)
    {
        this.mainController = mainController;
        this.product = product;
  


        InitializeComponent();
        InitializeData();


        buttonCopy.Click += CopyId;
        groupBox1.Click += change_selected_Id;
    }


    private void InitializeData()
    {
        labelIdText.Text = product.Id.ToString();
        labelNameText.Text = product.Name;
        labelPriceText.Text = product.Price.ToString();
    }


    private void CopyId(object sender, EventArgs e)
    {
        // Копирование текста в буфер обмена
        Clipboard.SetText(product.Id.ToString());
    }


    private void change_selected_Id(object sender, EventArgs e)
    {
        mainController.choisedProduct = product;
    }


}
