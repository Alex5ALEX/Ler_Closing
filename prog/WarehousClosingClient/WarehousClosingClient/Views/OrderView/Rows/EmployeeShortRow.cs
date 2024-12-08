using WarehousClosingClient.Models;

namespace WarehousClosingClient.Views.OrderView.Rows;

public partial class EmployeeShortRow : UserControl
{


    public Employee Employee { get; set; }
    public OrderAddController mainControllerAdd { get; set; }
    public OrderEditController mainControllerEdit { get; set; }

    public EmployeeShortRow(OrderAddController mainController, Employee Employee)
    {
        this.mainControllerAdd = mainController;
        this.Employee = Employee;


        InitializeComponent();
        InitData();

        groupBox1.Click += change_selected_Add_Employee;
        label1.Click += change_selected_Add_Employee;
        label2.Click += change_selected_Add_Employee;
        label3.Click += change_selected_Add_Employee;
        label4.Click += change_selected_Add_Employee;
    }


    public EmployeeShortRow(OrderEditController mainController, Employee Employee)
    {
        this.mainControllerEdit = mainController;
        this.Employee = Employee;


        InitializeComponent();
        InitData();

        groupBox1.Click += change_selected_Edit_Employee;
        label1.Click += change_selected_Edit_Employee;
        label2.Click += change_selected_Edit_Employee;
        label3.Click += change_selected_Edit_Employee;
        label4.Click += change_selected_Edit_Employee;
    }


    private void change_selected_Add_Employee(object sender, EventArgs e)
    {
        mainControllerAdd.choisedEmployee = Employee;
        mainControllerAdd.ShowEmployee();
    }


    private void change_selected_Edit_Employee(object sender, EventArgs e)
    {
        mainControllerEdit.choisedEmployee = Employee;
        mainControllerEdit.ShowEmployee();
    }



    public void InitData()
    {
        label3.Text = Employee.Name;
        label4.Text = Employee.Surname;
    }
}
