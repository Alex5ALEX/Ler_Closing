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
namespace WarehousClosingClient.Views.CustomerView;

public partial class CustomerRowControl : UserControl
{
    private CustomerControl mainController;
    private Customer customer;



    public CustomerRowControl(CustomerControl mainController, Customer customer)
    {
        this.mainController = mainController;
        this.customer = customer;
  


        InitializeComponent();
        InitializeData();


        buttonCopy.Click += CopyId;
        groupBox1.Click += change_selected_Id;
    }


    private void InitializeData()
    {
        labelIdText.Text = customer.Id.ToString();
        labelNameText.Text = customer.Name;
        labelSurnameText.Text = customer.Surname;
        labelPhoneText.Text = customer.Phone;
        labelEmailText.Text = customer.Email;
        labelAddresText.Text = customer.Address;
    }


    private void CopyId(object sender, EventArgs e)
    {
        // Копирование текста в буфер обмена
        Clipboard.SetText(customer.Id.ToString());
    }


    private void change_selected_Id(object sender, EventArgs e)
    {
        mainController.choisedCustomer = customer;
    }


}
