using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WarehousClosingClient.Views.CustomerView;

public partial class CustomerAddController : UserControl
{
    private CustomerControl _mainController;

    public CustomerAddController(CustomerControl mainController)
    {
        _mainController = mainController;

        InitializeComponent();

        buttonAdd.Click += AddNew;
        buttonBack.Click += Back;
    }

    private void Back(object? sender, EventArgs e)
    {
        _mainController.UpdateData();

        //throw new NotImplementedException();
    }

    private async void AddNew(object? sender, EventArgs e)
    {
        await _mainController.PostNewDataInApi(
        textBoxName.Text,
        textBoxSurname.Text,
        textBoxPhone.Text,
        textBoxEmail.Text,
        textBoxAddres.Text
        );


        textBoxSurname.Text = "";
        textBoxName.Text = "";
        textBoxPhone.Text = "";
        textBoxEmail.Text = "";
        textBoxAddres.Text = "";

        _mainController.UpdateData();

        //throw new NotImplementedException();
    }




}
