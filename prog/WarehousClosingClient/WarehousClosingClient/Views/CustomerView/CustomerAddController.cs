﻿
using WarehousClosingClient.Models;
using WarehousClosingClient.Logic;

namespace WarehousClosingClient.Views.CustomerView;

public partial class CustomerAddController : UserControl
{
    private CustomerControl mainController;
    private Validation validation;

    public CustomerAddController(CustomerControl mainController)
    {
        this.mainController = mainController;
        validation = new Validation();


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
        if (string.IsNullOrWhiteSpace(textBoxName.Text) ||
        string.IsNullOrWhiteSpace(textBoxSurname.Text) ||
        string.IsNullOrWhiteSpace(textBoxPhone.Text) ||
        string.IsNullOrWhiteSpace(textBoxEmail.Text) ||
        string.IsNullOrWhiteSpace(textBoxAddres.Text))
        {
            MessageBox.Show("Пожалуйста, заполните все поля.");
            return;
        }


        if (!validation.ValidatePhone(textBoxPhone.Text)) { MessageBox.Show("Телефон введен не верно!"); return; };
        if (!validation.ValidateEmail(textBoxEmail.Text)) { MessageBox.Show("Email введен не верно!");  return; };


        Customer customer = new Customer()
        {
            Name = textBoxName.Text,
            Surname = textBoxSurname.Text,
            Phone = textBoxPhone.Text,
            Email = textBoxEmail.Text,
            Address = textBoxAddres.Text
        };


        var response = mainController.customerController.PostCustomer(customer);


        textBoxSurname.Text = "";
        textBoxName.Text = "";
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
