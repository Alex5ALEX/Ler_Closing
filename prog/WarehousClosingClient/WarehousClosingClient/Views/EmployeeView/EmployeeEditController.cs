﻿using Newtonsoft.Json.Linq;
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
namespace WarehousClosingClient.Views.EmployeeView;

public partial class EmployeeEditController : UserControl
{
    private EmployeeControl mainController;
    private Employee employee;



    public EmployeeEditController(EmployeeControl mainController, Employee employee)
    {
        this.mainController = mainController;
        this.employee = employee;

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
        richTextBoxId.Text = employee.Id.ToString();
        textBoxName.Text = employee.Name;
        textBoxSurname.Text = employee.Surname;
        textBoxJobtitle.Text = employee.JobTitle;
        textBoxPhone.Text = employee.Phone;
        textBoxEmail.Text = employee.Email;
        textBoxAddres.Text = employee.Address;
    }



    private void Edit(object? sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(textBoxName.Text) ||
        string.IsNullOrWhiteSpace(textBoxSurname.Text) ||
        string.IsNullOrWhiteSpace(textBoxJobtitle.Text) ||
        string.IsNullOrWhiteSpace(textBoxPhone.Text) ||
        string.IsNullOrWhiteSpace(textBoxEmail.Text) ||
        string.IsNullOrWhiteSpace(textBoxAddres.Text))
        {
            MessageBox.Show("Пожалуйста, заполните все поля.");
            return;
        }


        employee.Name = textBoxName.Text;
        employee.Surname = textBoxSurname.Text;
        employee.JobTitle = textBoxJobtitle.Text;
        employee.Phone = textBoxPhone.Text;
        employee.Email = textBoxEmail.Text;
        employee.Address = textBoxAddres.Text;

        var response = mainController.employeeController.PutEmployee(employee);

        if (response.Result.IsSuccessStatusCode)
        {
            mainController.UpdateData();
        }
    }


    private void Delete(object? sender, EventArgs e)
    {
        DialogResult result = MessageBox.Show("Are you sure want to delete?", "", MessageBoxButtons.YesNo);

        if (result == DialogResult.No) { return; }


        var response = mainController.employeeController.DelEmployee(employee);

        if (response.Result.IsSuccessStatusCode)
        {
            mainController.UpdateData();
            Back(sender, e);
        }
    }


}
