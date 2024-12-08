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
namespace WarehousClosingClient.Views.OrderView;

public partial class OrderRowControl : UserControl
{
    private OrderControl mainController;
    private Order order;



    public OrderRowControl(OrderControl mainController, Order order)
    {
        this.mainController = mainController;
        this.order = order;
  


        InitializeComponent();
        InitData();

        groupBox1.Click += change_selected_Id;
        groupBox2.Click += change_selected_Id;
        groupBox3.Click += change_selected_Id;
        labelDate.Click += change_selected_Id;
        labelDateText.Click += change_selected_Id;
        label1.Click += change_selected_Id;
        label2.Click += change_selected_Id;
        label3.Click += change_selected_Id;
        label4.Click += change_selected_Id;
        label5.Click += change_selected_Id;
        label6.Click += change_selected_Id;
        label7.Click += change_selected_Id;
    }


    private void InitData()
    {
        labelDateText.Text = order.Date.ToString("dd MM yyyy");

        InitCustomer();
        InitEmployee();
    }

    private async void InitCustomer()
    {
        Customer customer = await mainController.customerController.GetCustomerById(order.Id_Customer);
    
        label1.Text = customer.Name;
        label2.Text = customer.Surname;
        label3.Text = customer.Phone;
    }

    private async void InitEmployee()
    {
        Employee employee = await mainController.employeeController.GetEmployeeById(order.Id_Employee);

        label4.Text = employee.Name;
        label5.Text = employee.Surname;
        label6.Text = employee.JobTitle;
        label7.Text = employee.Phone;

    }



    private void change_selected_Id(object sender, EventArgs e)
    {
        mainController.choisedOrder = order;
    }

    
}
