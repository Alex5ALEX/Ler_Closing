using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using WarehousClosingClient.Views.CustomerView;
using WarehousClosingClient.Views.EmployeeView;
using WarehousClosingClient.Views.OrderView;
using WarehousClosingClient.Views.ProductView;
using WarehousClosingClient.Views.ProviderView;
using WarehousClosingClient.Views.SupplyView;



namespace WarehousClosingClient;

public partial class MainForm : Form
{

    public HttpClient httpClient { get; set; }

    CustomerControl customerControl;
    EmployeeControl employeeControl;
    OrderControl orderControl;
    ProductControl productControl;
    ProviderControl providerControl;
    SupplyControl supplyControl;


    public MainForm()
    {
        InitializeComponent();
        InitializeData();

        this.FormClosing += new FormClosingEventHandler(Form_FormClosing);

        buttonMenu.Click += CallMenu;
        buttonHideMenu.Click += ClearMenu;
        labelMenu.Click += ClearMenu;

        customerOption.Click += InitCustomerControl;
        employeeOption.Click += InitEmployeeControl;
        orderOption.Click += InitOrderControl;
        productOption.Click += InitProductControl;
        providerOption.Click += InitProviderControl;
        supplyOption.Click += InitSupplyControl;

    }



    private void InitializeData()
    {
        httpClient = new HttpClient();

        customerControl = new CustomerControl(this);
        employeeControl = new EmployeeControl(this);
        orderControl = new OrderControl(this);
        productControl = new ProductControl(this);
        providerControl = new ProviderControl(this);
        supplyControl = new SupplyControl(this);

        groupBoxMenu.Visible = false;
    }


    //menu options
    private void InitCustomerControl(object sender, EventArgs e)
    {
        HideMenuControl();
        groupBoxMain.Controls.Clear();
        groupBoxMain.Controls.Add(customerControl);
    }

    private void InitEmployeeControl(object sender, EventArgs e)
    {
        HideMenuControl();
        groupBoxMain.Controls.Clear();
        groupBoxMain.Controls.Add(employeeControl);
    }

    private void InitOrderControl(object sender, EventArgs e)
    {
        HideMenuControl();
        groupBoxMain.Controls.Clear();
        groupBoxMain.Controls.Add(orderControl);
    }

    private void InitProductControl(object sender, EventArgs e)
    {
        HideMenuControl();
        groupBoxMain.Controls.Clear();
        groupBoxMain.Controls.Add(productControl);
    }

    private void InitProviderControl(object sender, EventArgs e)
    {
        HideMenuControl();
        groupBoxMain.Controls.Clear();
        groupBoxMain.Controls.Add(providerControl);
    }

    private void InitSupplyControl(object sender, EventArgs e)
    {
        HideMenuControl();
        groupBoxMain.Controls.Clear();
        groupBoxMain.Controls.Add(supplyControl);
    }


    //menu
    private void CallMenu(object sender, EventArgs e)
    {
        ShowMenuControl();
    }

    private void ClearMenu(object sender, EventArgs e)
    {
        HideMenuControl();
    } 

    public void ShowMenuControl()
    {
        groupBoxMenu.BringToFront();
        groupBoxMenu.Visible = true;
    }

    public void HideMenuControl()
    {
        groupBoxMenu.Visible = false;
    }


    //exit
    private void Form_FormClosing(object sender, FormClosingEventArgs e)
    {
        DialogResult result = MessageBox.Show("Are you sure want to exit?", "", MessageBoxButtons.YesNo);

        if (result == DialogResult.No)
        {
            e.Cancel = true;
        }
    }



}
