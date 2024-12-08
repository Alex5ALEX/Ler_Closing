using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using WarehousClosingClient.Models;

namespace WarehousClosingClient.Views.ReportView;

public partial class FinanceControl : UserControl
{
    List<Order> orders { get; set; } = [];
    List<Supply> supplies { get; set; } = [];

    private ReportControl mainController;

    public FinanceControl(ReportControl mainController)
    {
        this.mainController = mainController;

        InitializeComponent();
        InitData();

    }


    private async void InitData()
    {
        orders = await mainController.orderController.GetAllOrdersAsync();

        decimal profit = 0;
        foreach (Order order in orders) {
            List <OrderCompaund> compaunds = await mainController.orderCompaundController.GetOrderCompaundByIdOrder(order.Id);

            foreach(OrderCompaund compaund in compaunds)
            {
                Product product = await mainController.productController.GetProductById(compaund.Id_Product);

                profit += compaund.Quantity * product.Price;
            }

        }

        label2.Text = profit.ToString("0.00");
        label4.Text = orders.Count.ToString();


        supplies = await mainController.supplyController.GetAllSupplyAsync();

        decimal cost = 0;
        foreach (Supply supply in supplies) 
        {
            cost += supply.Price;
        }

        label6.Text = cost.ToString("0.00");
        label7.Text = supplies.Count.ToString();


        InitPositiveSchedule();
        InitNegagtiveSchedule();
    }



    private async void InitPositiveSchedule()
    {
        chart1.Series.Clear();
        Series series = new Series()
        {
            Name = "TotalCostPerYear",
            Color = System.Drawing.Color.Green,
            ChartType = SeriesChartType.Column // Столбчатая диаграмма
        };

        
        foreach  (Order  order in orders)
        {
            decimal profit = 0;
            List<OrderCompaund> compaunds = await mainController.orderCompaundController.GetOrderCompaundByIdOrder(order.Id);

            foreach (OrderCompaund compaund in compaunds)
            {
                Product product = await mainController.productController.GetProductById(compaund.Id_Product);

                profit += compaund.Quantity * product.Price;
            }

            series.Points.AddXY(order.Date.Year, profit);
        }

        chart1.Series.Add(series);

        // Настройка осей
        chart1.ChartAreas[0].AxisX.Title = "Years";
        chart1.ChartAreas[0].AxisY.Title = "Total Profit";

        // Заголовок диаграммы
        chart1.Titles.Add("Profit in Year");


    }


    private void InitNegagtiveSchedule()
    {
        chart2.Series.Clear();
        Series series = new Series()
        {
            Name = "TotalExpensesPerYear",
            Color = System.Drawing.Color.Red,
            ChartType = SeriesChartType.Column // Столбчатая диаграмма
        };


        foreach (Supply supply in supplies)
        {
            series.Points.AddXY(supply.Date.Year, supply.Price);
        }

        chart2.Series.Add(series);

        // Настройка осей
        chart2.ChartAreas[0].AxisX.Title = "Years";
        chart2.ChartAreas[0].AxisY.Title = "Total expenses";

        // Заголовок диаграммы
        chart2.Titles.Add("Expenses in Year");
    }

}
