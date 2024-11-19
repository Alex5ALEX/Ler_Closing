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

public partial class CustomerRowControl : UserControl
{
    private CustomerControl _mainController;


    public CustomerRowControl(CustomerControl _mainController)
    {
        this._mainController = _mainController;



        
        InitializeComponent();





        buttonCopy.Click += CopyId;
        this.Click += change_selected_Id;
    }

    public CustomerRowControl(
        CustomerControl _mainController,
        string id,
        string name,
        string surname,
        string phone,
        string email,
        string addres) : this(_mainController)
    {
        labelIdText.Text = id;
        labelNameText.Text = name;
        labelSurnameText.Text = surname;
        labelPhoneText.Text = phone;
        labelEmailText.Text = email;
        labelAddresText.Text = addres;

    }


    private void CopyId(object sender, EventArgs e)
    {
        // Копирование текста в буфер обмена
        Clipboard.SetText(labelIdText.Text);
    }


    private void change_selected_Id(object sender, EventArgs e)
    {
        _mainController._choisedId = Guid.Parse(labelIdText.Text);
    }


}
