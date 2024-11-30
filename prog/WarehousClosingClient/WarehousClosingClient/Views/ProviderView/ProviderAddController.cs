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

namespace WarehousClosingClient.Views.ProviderView;

public partial class ProviderAddController : UserControl
{
    private ProviderControl mainController;

    public ProviderAddController(ProviderControl mainController)
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
        if (string.IsNullOrWhiteSpace(textBoxCompany.Text) ||
        string.IsNullOrWhiteSpace(textBoxContactPerson.Text) ||
        string.IsNullOrWhiteSpace(textBoxPhone.Text) ||
        string.IsNullOrWhiteSpace(textBoxEmail.Text) ||
        string.IsNullOrWhiteSpace(textBoxAddres.Text))
        {
            MessageBox.Show("Пожалуйста, заполните все поля.");
            return;
        }


        Provider provider = new Provider()
        {
            Company = textBoxCompany.Text,
            ContactPerson = textBoxContactPerson.Text,
            Phone = textBoxPhone.Text,
            Email = textBoxEmail.Text,
            Address = textBoxAddres.Text
        };


        var response = mainController.providerController.PostProvider(provider);


        textBoxContactPerson.Text = "";
        textBoxCompany.Text = "";
        textBoxPhone.Text = "";
        textBoxEmail.Text = "";
        textBoxAddres.Text = "";


        if (response.Result.IsSuccessStatusCode)
        {
            mainController.UpdateData();
        }

        //throw new NotImplementedException();
    }


}
