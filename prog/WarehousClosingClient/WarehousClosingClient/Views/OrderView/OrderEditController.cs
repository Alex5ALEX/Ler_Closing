using Newtonsoft.Json.Linq;
using System;
using System.CodeDom.Compiler;
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
using WarehousClosingClient.Views.OrderView.Rows;
namespace WarehousClosingClient.Views.OrderView;

public partial class OrderEditController : UserControl
{
    private OrderControl mainController;
    private Order order;

    private List<OrderCompaund> orderCompaundRow { get; set; } = [];
    private List<ProductShortRow> productRow { get; set; } = [];
    private List<CustomerShortRow> customerRow { get; set; } = [];
    private List<EmployeeShortRow> employeeRow { get; set; } = [];


    public Customer choisedCustomer { get; set; }
    public Employee choisedEmployee { get; set; }



    public OrderEditController(OrderControl mainController, Order order)
    {
        this.mainController = mainController;
        this.order = order;

      

        InitializeComponent();
        InitData();


        buttonBack.Click += Back;
        buttonEdit.Click += Edit;
        buttonDelete.Click += Delete;
    }




    private void Back(object? sender, EventArgs e)
    {
        mainController.HideActionGroupBox();
    }

    //data
    private async void InitData()
    {
        dateTimePicker.Value = order.Date;

        choisedCustomer = await mainController.customerController.GetCustomerById(order.Id_Customer);
        choisedEmployee = await mainController.employeeController.GetEmployeeById(order.Id_Employee);

        ShowCustomer();
        ShowEmployee();

        InitProducts();
        InitCustomer();
        InitEmployee();

    }


    public async void InitProducts()
    {
        flowLayoutPanelProducts.Controls.Clear();
        productRow.Clear();

        var products = await mainController.productController.GetAllProductsAsync();

        foreach (var item in products)
        {
            var token = new ProductShortRow(item);
            productRow.Add(token);
            flowLayoutPanelProducts.Controls.Add(token);
        }


        orderCompaundRow = await mainController.orderCompaundController.GetOrderCompaundByIdOrder(order.Id);

        foreach(var item in orderCompaundRow)
        {
            foreach (var productline in productRow)
            {
                if (productline.product.Id == item.Id_Product)
                {
                    productline.SetQuantity(item.Quantity);
                }

            }
        }
    }



    public async void InitCustomer()
    {
        flowLayoutPanelCustomers.Controls.Clear();
        customerRow.Clear();

        var customers = await mainController.customerController.GetAllCustomersAsync();

        foreach (var item in customers)
        {
            var token = new CustomerShortRow(this, item);
            customerRow.Add(token);
            flowLayoutPanelCustomers.Controls.Add(token);
        }
    }

    public async void InitEmployee()
    {
        flowLayoutPanelEmployers.Controls.Clear();
        employeeRow.Clear();

        var employee = await mainController.employeeController.GetAllEmployersAsync();

        foreach (var item in employee)
        {
            var token = new EmployeeShortRow(this, item);
            employeeRow.Add(token);
            flowLayoutPanelEmployers.Controls.Add(token);
        }
    }




    //action

    public void ShowCustomer()
    {
        label1.Text = choisedCustomer.Name;
        label2.Text = choisedCustomer.Surname;
        label3.Text = choisedCustomer.Phone;
        label4.Text = choisedCustomer.Email;
    }

    public void ShowEmployee()
    {
        label8.Text = choisedEmployee.Name;
        label7.Text = choisedEmployee.Surname;
        label6.Text = choisedEmployee.Phone;
        label5.Text = choisedEmployee.Email;
    }


    private async void Edit(object? sender, EventArgs e)
    {

        order.Date = dateTimePicker.Value;
        order.Id_Customer = choisedCustomer.Id;
        order.Id_Employee = choisedEmployee.Id;


        var response = await mainController.orderController.PutOrder(order);


        foreach(var prod in productRow)
        {
            bool temp = false;

            foreach(var orderCompaund in orderCompaundRow)
            {
                if(prod.product.Id == orderCompaund.Id_Product)
                {
                    temp = true;
                    if(prod.GetQuantity() != orderCompaund.Quantity)
                    {
                        orderCompaund.Quantity = prod.GetQuantity();
                        mainController.orderCompaundController.PutOrderCompaund(orderCompaund);
                    }
                    break;
                }
            }
            if(temp == false)
            {
                if (prod.GetQuantity() > 0)
                {
                    OrderCompaund compaund = new OrderCompaund()
                    {
                        Id_Order = order.Id,
                        Id_Product = prod.product.Id,
                        Quantity = prod.GetQuantity()
                    };


                    var responseCompaund = await mainController.orderCompaundController.PostOrderCompaund(compaund);

                    if (responseCompaund.IsSuccessStatusCode) { continue; }
                }
            }
        }

        InitData();
        mainController.UpdateData();
    }

    



    private void Delete(object? sender, EventArgs e)
    {
        DialogResult result = MessageBox.Show("Are you sure want to delete?", "", MessageBoxButtons.YesNo);

        if (result == DialogResult.No){return;}


        var response = mainController.orderController.DelOrder(order);

        foreach (var item in orderCompaundRow)
        {
            mainController.orderCompaundController.DelOrderCompaund(item);
        }


        if (response.Result.IsSuccessStatusCode)
        {
            mainController.UpdateData();
            Back(sender, e);
        }
    }
    
}
