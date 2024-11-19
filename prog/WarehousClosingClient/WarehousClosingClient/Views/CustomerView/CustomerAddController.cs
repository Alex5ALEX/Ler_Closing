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

        buttonBack.Click += Back;
        buttonAdd.Click += AddItem;
    }

    private void Back(object? sender, EventArgs e)
    {
        _mainController.UpdateData();
    }

    private async void AddItem(object? sender, EventArgs e)
    {
        await _mainController.PostCustomer(
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
