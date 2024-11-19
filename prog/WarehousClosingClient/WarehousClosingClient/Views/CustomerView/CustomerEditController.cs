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

namespace WarehousClosingClient.Views.CustomerView;

public partial class CustomerEditController : UserControl
{
    private CustomerControl _mainController;


    public CustomerEditController(CustomerControl _mainController)
    {
        this._mainController = _mainController;

        InitializeComponent();
        InitializeData();


        buttonBack.Click += Back;
        buttonEdit.Click += EditItem;
        buttonDelete.Click += DeleteItem;
    }




    private void Back(object? sender, EventArgs e)
    {
        _mainController.UpdateData();

    }


    private async void InitializeData()
    {
        labelIdText.Text = _mainController._choisedId.ToString();

        var data = await _mainController.GetCustomerById(_mainController._choisedId);

        var customer = JObject.Parse(data);
        
        textBoxName.Text = customer["name"]?.ToString();
        textBoxSurname.Text = customer["surname"]?.ToString();
        textBoxPhone.Text = customer["phone"]?.ToString();
        textBoxEmail.Text = customer["email"]?.ToString();
        textBoxAddres.Text = customer["address"]?.ToString();
    }

    private void EditItem(object? sender, EventArgs e)
    {
        var response = _mainController.PutCustomerById(
            Guid.Parse(labelIdText.Text),
            textBoxName.Text,
            textBoxSurname.Text,
            textBoxPhone.Text,
            textBoxEmail.Text,
            textBoxAddres.Text
            );

        if (response.Result.IsSuccessStatusCode) {
            Back(sender, e);
        }

        //Back(sender, e);
    }

    private void DeleteItem(object? sender, EventArgs e)
    {
        var response = _mainController.DelCustomer(_mainController._choisedId);

        if (response.Result.IsSuccessStatusCode)
        {
            Back(sender, e);
        }

        //Back(sender, e);
    }

}
