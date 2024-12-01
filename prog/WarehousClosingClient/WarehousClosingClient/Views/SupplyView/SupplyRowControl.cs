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
        InitializeData();


        buttonCopy.Click += CopyId;
        buttonCopyProvider.Click += CopyIdProvider;
        groupBox1.Click += change_selected_Id;
        Click += change_selected_Id;
    }


    private void InitializeData()
    {
        labelIdText.Text = supply.Id.ToString();
        labelDateText.Text = supply.Date.ToString("dd MM yyyy");
        labelPriceText.Text = supply.Price.ToString();
        labelProviderText.Text = supply.Id_Provider.ToString();
    }


    private void CopyId(object sender, EventArgs e)
    {
        // Копирование текста в буфер обмена
        Clipboard.SetText(supply.Id.ToString());
    }


    private void CopyIdProvider(object sender, EventArgs e)
    {
        // Копирование текста в буфер обмена
        Clipboard.SetText(supply.Id_Provider.ToString());
    }


    private void change_selected_Id(object sender, EventArgs e)
    {
        mainController.choisedSupply = supply;
    }

    
}
