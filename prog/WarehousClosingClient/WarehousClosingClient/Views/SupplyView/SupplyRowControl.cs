using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using WarehousClosingClient.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
namespace WarehousClosingClient.Views.SupplyView;

public partial class SupplyRowControl : UserControl
{
    private SupplyControl mainController;
    private Supply supply;



    public SupplyRowControl(SupplyControl mainController, Supply supply)
    {
        this.mainController = mainController;
        this.supply = supply;
  

        InitializeComponent();
        InitData();



        groupBox1.Click += change_selected_Id;
        groupBox2.Click += change_selected_Id;
        labelDate.Click += change_selected_Id;
        labelDateText.Click += change_selected_Id;
        labelPrice.Click += change_selected_Id;
        labelPriceText.Click += change_selected_Id;
        label1.Click += change_selected_Id;
        label2.Click += change_selected_Id;
        label3.Click += change_selected_Id;
    }


    private void InitData()
    {
        labelDateText.Text = supply.Date.ToString("dd MM yyyy");
        labelPriceText.Text = supply.Price.ToString();

        InitProvider();
    }


    private async void InitProvider()
    {
        Provider provider = await mainController.providerController.GetProviderById(supply.Id_Provider);

        label1.Text = provider.Company;
        label2.Text = provider.ContactPerson;
        label3.Text = provider.Phone;

    }


    private void change_selected_Id(object sender, EventArgs e)
    {
        mainController.choisedSupply = supply;
    }

    
}
