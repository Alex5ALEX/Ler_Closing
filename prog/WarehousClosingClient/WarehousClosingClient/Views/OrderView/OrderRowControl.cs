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
        InitializeData();


        buttonCopy.Click += CopyId;
        buttonCopyCustomer.Click += CopyIdCustomer;
        buttonCopyEmployee.Click += CopyIdEmployee;
        groupBox1.Click += change_selected_Id;
        Click += change_selected_Id;
    }


    private void InitializeData()
    {
        labelIdText.Text = order.Id.ToString();
        labelDateText.Text = order.Date.ToString("dd MM yyyy");
        labelCustomerText.Text = order.Id_Customer.ToString();
        labelEmployeeText.Text = order.Id_Employee.ToString();
    }


    private void CopyId(object sender, EventArgs e)
    {
        // Копирование текста в буфер обмена
        Clipboard.SetText(order.Id.ToString());
    }


    private void CopyIdCustomer(object sender, EventArgs e)
    {
        // Копирование текста в буфер обмена
        Clipboard.SetText(order.Id_Customer.ToString());
    }


    private void CopyIdEmployee(object sender, EventArgs e)
    {
        // Копирование текста в буфер обмена
        Clipboard.SetText(order.Id_Employee.ToString());
    }


    private void change_selected_Id(object sender, EventArgs e)
    {
        mainController.choisedOrder = order;
    }

    
}
