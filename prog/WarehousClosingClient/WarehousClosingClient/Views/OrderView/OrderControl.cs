using Newtonsoft.Json.Linq;

using WarehousClosingClient.Controllers;
using WarehousClosingClient.Models;
namespace WarehousClosingClient.Views.OrderView;

public partial class OrderControl : UserControl
{
    private MainForm mainForm;

    public OrderController orderController;
    public ProductController productController;
    public EmployeeController employeeController;
    public CustomerController customerController;
    public OrderCompaundController orderCompaundController;

    private OrderAddController orderAdd;

    public List<Order> orders { get; set; }
    public Order choisedOrder { get; set; }
    



    public OrderControl(MainForm mainForm)
    {
        this.mainForm = mainForm;


        InitializeComponent();
        InitializeData();
        UpdateData();


        buttonMenu.Click += CallMenu;

        buttonAddNew.Click += AddNew;
        buttonEdit.Click += Edit;
    }
    


    private void InitializeData()
    {
        choisedOrder = new Order();

        orderController = new OrderController(mainForm.httpClient);
        productController = new ProductController(mainForm.httpClient);
        employeeController = new EmployeeController(mainForm.httpClient);
        customerController = new CustomerController(mainForm.httpClient);
        orderCompaundController = new OrderCompaundController(mainForm.httpClient);

        orderAdd = new OrderAddController(this);
    }



    private void CallMenu(object sender, EventArgs e)
    {
        mainForm.ShowMenuControl();
    }



    public async void UpdateData()
    {
        flowLayoutPanel.Controls.Clear();

        orders = await orderController.GetAllOrdersAsync();
        
        foreach (var item in orders)
        {
            flowLayoutPanel.Controls.Add(new OrderRowControl(this, item));
        }
        
    }


    //можно добавить функционал
    public void HideActionGroupBox()
    {
        groupBoxAction.Controls.Clear();
    }

    private void AddNew(object? sender, EventArgs e)
    {
        groupBoxAction.Controls.Clear();
        orderAdd.InitializeData();
        groupBoxAction.Controls.Add(orderAdd);
    }

    private void Edit(object? sender, EventArgs e)
    {
        if(choisedOrder.Id == Guid.Empty) { return; }

        groupBoxAction.Controls.Clear();
        groupBoxAction.Controls.Add(new OrderEditController(this, choisedOrder));
    }

    
}
