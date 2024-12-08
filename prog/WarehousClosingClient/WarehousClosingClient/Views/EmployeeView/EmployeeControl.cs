using Newtonsoft.Json.Linq;

using WarehousClosingClient.Controllers;
using WarehousClosingClient.Models;
namespace WarehousClosingClient.Views.EmployeeView;

public partial class EmployeeControl : UserControl
{
    private MainForm mainForm;
    public EmployeeController employeeController;
    private EmployeeAddController employeeAdd;

    public List<Employee> employers { get; set; }
    public Employee choisedEmployee { get; set; }




    public EmployeeControl(MainForm mainForm)
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
        choisedEmployee = new Employee();
        employeeController = new EmployeeController(mainForm.httpClient);
        employeeAdd = new EmployeeAddController(this);
    }



    private void CallMenu(object sender, EventArgs e)
    {
        mainForm.ShowMenuControl();
    }



    public async void UpdateData()
    {
        flowLayoutPanel.Controls.Clear();

        employers = await employeeController.GetAllEmployersAsync();

        foreach (var employee in employers)
        {
            flowLayoutPanel.Controls.Add(new EmployeeRowControl(this, employee));
        }

    }


    //можно добавить функционал
    public void HideActionGroupBox()
    {
        groupBoxAction.Controls.Clear();
        pictureBox1.Visible = true;
    }

    private void AddNew(object? sender, EventArgs e)
    {
        pictureBox1.Visible = false;
        groupBoxAction.Controls.Clear();
        groupBoxAction.Controls.Add(employeeAdd);
    }

    private void Edit(object? sender, EventArgs e)
    {
        if (choisedEmployee.Id == Guid.Empty) { return; }

        pictureBox1.Visible = false;
        groupBoxAction.Controls.Clear();
        groupBoxAction.Controls.Add(new EmployeeEditController(this, choisedEmployee));
    }

}
