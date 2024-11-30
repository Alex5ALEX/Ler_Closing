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
namespace WarehousClosingClient.Views.ProviderView;

public partial class ProviderRowControl : UserControl
{
    private ProviderControl mainController;
    private Provider provider;



    public ProviderRowControl(ProviderControl mainController, Provider provider)
    {
        this.mainController = mainController;
        this.provider = provider;
  


        InitializeComponent();
        InitializeData();


        buttonCopy.Click += CopyId;
        groupBox1.Click += change_selected_Id;
    }


    private void InitializeData()
    {
        labelIdText.Text = provider.Id.ToString();
        labelCompanyText.Text = provider.Company;
        labelContactPersonText.Text = provider.ContactPerson;
        labelPhoneText.Text = provider.Phone;
        labelEmailText.Text = provider.Email;
        labelAddresText.Text = provider.Address;
    }


    private void CopyId(object sender, EventArgs e)
    {
        // Копирование текста в буфер обмена
        Clipboard.SetText(provider.Id.ToString());
    }


    private void change_selected_Id(object sender, EventArgs e)
    {
        mainController.choisedProvider = provider;
    }


}
