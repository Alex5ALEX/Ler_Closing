
using WarehousClosingClient.Logic;
using WarehousClosingClient.Models;

namespace WarehousClosingClient.Views.EmployeeView;

public partial class EmployeeAddController : UserControl
{
    private EmployeeControl mainController;
    private Validation validation;

    public EmployeeAddController(EmployeeControl mainController)
    {
        this.mainController = mainController;
        validation = new Validation();


        InitializeComponent();

        buttonBack.Click += Back;
        buttonAdd.Click += AddItem;
    }

    private void Back(object? sender, EventArgs e)
    {
        mainController.HideActionGroupBox();
    }



    private void AddItem(object? sender, EventArgs e)
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

        if (!validation.ValidatePhone(textBoxPhone.Text)) { MessageBox.Show("Телефон введен не верно!"); return; };
        if (!validation.ValidateEmail(textBoxEmail.Text)) { MessageBox.Show("Email введен не верно!"); return; };


        Employee employee = new Employee()
        {
            Name = textBoxName.Text,
            Surname = textBoxSurname.Text,
            JobTitle = textBoxJobtitle.Text,
            Phone = textBoxPhone.Text,
            Email = textBoxEmail.Text,
            Address = textBoxAddres.Text
        };


        var response = mainController.employeeController.PostEmployee(employee);


        textBoxSurname.Text = "";
        textBoxName.Text = "";
        textBoxJobtitle.Text = "";
        textBoxPhone.Text = "";
        textBoxEmail.Text = "";
        textBoxAddres.Text = "";


        if (response.Result.IsSuccessStatusCode)
        {
            mainController.UpdateData();
        }

        //throw new NotImplementedException();
    }


}
