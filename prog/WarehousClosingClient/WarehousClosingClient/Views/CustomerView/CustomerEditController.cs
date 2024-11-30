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


using WarehousClosingClient.Models;
namespace WarehousClosingClient.Views.CustomerView;

public partial class CustomerEditController : UserControl
{
    private CustomerControl mainController;
    private Customer customer;



    public CustomerEditController(CustomerControl mainController, Customer customer)
    {
        this.mainController = mainController;
        this.customer = customer;

        InitializeComponent();
        InitializeData();


        buttonBack.Click += Back;
        buttonEdit.Click += Edit;
        buttonDelete.Click += Delete;
    }




    private void Back(object? sender, EventArgs e)
    {
        mainController.HideActionGroupBox();
    }


    private async void InitializeData()
    {
        richTextBoxId.Text = customer.Id.ToString();
        textBoxName.Text = customer.Name;
        textBoxSurname.Text = customer.Surname;
        textBoxPhone.Text = customer.Phone;
        textBoxEmail.Text = customer.Email;
        textBoxAddres.Text = customer.Address;
    }

       

    private void Edit(object? sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(textBoxName.Text) ||
        string.IsNullOrWhiteSpace(textBoxSurname.Text) ||
        string.IsNullOrWhiteSpace(textBoxPhone.Text) ||
        string.IsNullOrWhiteSpace(textBoxEmail.Text) ||
        string.IsNullOrWhiteSpace(textBoxAddres.Text))
        {
            MessageBox.Show("Пожалуйста, заполните все поля.");
            return;
        }


        customer.Name = textBoxName.Text;
        customer.Surname = textBoxSurname.Text;
        customer.Phone = textBoxPhone.Text;
        customer.Email = textBoxEmail.Text;
        customer.Address = textBoxAddres.Text;

        var response = mainController.customerController.PutCustomerById(customer);

        if (response.Result.IsSuccessStatusCode) {
            mainController.UpdateData();
        }
    }


    private void Delete(object? sender, EventArgs e)
    {
        DialogResult result = MessageBox.Show("Are you sure want to delete?", "", MessageBoxButtons.YesNo);

        if (result == DialogResult.No){return;}


        var response = mainController.customerController.DelCustomer(customer);

        if (response.Result.IsSuccessStatusCode)
        {
            mainController.UpdateData();
            Back(sender, e);
        }
    }

}
