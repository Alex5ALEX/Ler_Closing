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
namespace WarehousClosingClient.Views.OrderView;

public partial class OrderEditController : UserControl
{
    private OrderControl mainController;
    private Order order;

    private List<OrderCompaund> orderCompaunds { get; set; } = [];
    private List<ProductAddRowControl> productRow { get; set; } = [];



    public OrderEditController(OrderControl mainController, Order order)
    {
        this.mainController = mainController;
        this.order = order;

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
        textBoxId.Text = order.Id.ToString();
        textBoxDate.Text = order.Date.ToString("dd MM yyyy");
        textBoxCustomer.Text = order.Id_Customer.ToString();
        textBoxEmployee.Text = order.Id_Employee.ToString();



        orderCompaunds = await mainController.orderCompaundController.GetOrderCompaundByIdOrder(order.Id);

        foreach (var item in orderCompaunds)
        {
            Product token = await mainController.productController.GetProductById(item.Id_Product);
            
            if(token.Id == Guid.Empty) { continue; }

            var temp = new ProductAddRowControl(token);
            temp.SetQuantity(item.Quantity);
            productRow.Add(temp);
            flowLayoutPanel1.Controls.Add(temp);
        }
    }

       

    private async void Edit(object? sender, EventArgs e)
    {
        //проверка что пользователь ввел все поля
        if (string.IsNullOrWhiteSpace(textBoxDate.Text) ||
        string.IsNullOrWhiteSpace(textBoxCustomer.Text) ||
        string.IsNullOrWhiteSpace(textBoxEmployee.Text))
        {
            MessageBox.Show("Пожалуйста, заполните все поля.");
            return;
        }


        //проверка на правильный ввод даты
        DateTime date = DateTime.Now;

        if (!DateTime.TryParseExact(textBoxDate.Text, "d M yyyy", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out date))
        {
            MessageBox.Show("Дата введена не верно. Введите в формате: dd MM yyyy");
            return;
        }


        //проверка на наличие клиента/ работника
        Guid idEmployee = Guid.Empty;
        Guid idCustomer = Guid.Empty;

        if (!Guid.TryParse(textBoxEmployee.Text, out idEmployee) ||
            !Guid.TryParse(textBoxCustomer.Text, out idCustomer))
        {
            MessageBox.Show("id введен ен верно");
            return;
        }

        if (!await mainController.employeeController.employeeExist(idEmployee))
        {
            MessageBox.Show("Работника не существует");
            return;
        }

        if (!await mainController.customerController.customerExist(idCustomer))
        {
            MessageBox.Show("Клиента не существует");
            return;
        }

        
        if (await editOrder(date, idCustomer, idEmployee))
        {
            textBoxDate.Text = string.Empty;
            textBoxCustomer.Text = string.Empty;
            textBoxEmployee.Text = string.Empty;

            InitializeData();
            mainController.UpdateData();
        }


    }

    
    private async Task<bool> editOrder(DateTime date, Guid idCustomer, Guid idEmployee)
    {
        order.Date = date;
        order.Id_Customer = idCustomer;
        order.Id_Employee = idEmployee;



        var response = await mainController.orderController.PutOrder(order);

        foreach (var item in productRow)//List<ProductAddRowControl>
        { 

            foreach(var temp in orderCompaunds)//List<OrderCompaund>
            {

                if(item.product.Id == temp.Id_Product)
                {
                    
                    if(item.GetQuantity() != temp.Quantity)
                    {
                        temp.Quantity = item.GetQuantity();
                        mainController.orderCompaundController.PutOrderCompaund(temp);
                    }
                }
            }
           
        }

        return true;//вернуть если успешно
    }


    private void Delete(object? sender, EventArgs e)
    {
        DialogResult result = MessageBox.Show("Are you sure want to delete?", "", MessageBoxButtons.YesNo);

        if (result == DialogResult.No){return;}


        var response = mainController.orderController.DelOrder(order);

        foreach (var item in orderCompaunds)
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
