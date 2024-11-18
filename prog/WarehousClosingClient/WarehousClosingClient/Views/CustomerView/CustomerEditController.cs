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

public partial class CustomerEditController : UserControl
{
    private CustomerControl _mainController;


    public CustomerEditController(CustomerControl _mainController)
    {
        this._mainController = _mainController;

        InitializeComponent();
        InitializeData();


        buttonBack.Click += Back;
    }




    private void Back(object? sender, EventArgs e)
    {
        _mainController.UpdateData();

        //throw new NotImplementedException();
    }


    private void InitializeData()
    {
        labelIdText.Text = _mainController._choisedId.ToString();





    }

}
