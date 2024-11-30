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
namespace WarehousClosingClient.Views.EmployeeView;

public partial class EmployeeRowControl : UserControl
{
    private EmployeeControl mainController;
    private Employee employee;



    public EmployeeRowControl(EmployeeControl mainController, Employee employee)
    {
        this.mainController = mainController;
        this.employee = employee;
  


        InitializeComponent();
        InitializeData();


        buttonCopy.Click += CopyId;
        groupBox1.Click += change_selected_Id;
    }


    private void InitializeData()
    {
        labelIdText.Text = employee.Id.ToString();
        labelNameText.Text = employee.Name;
        labelSurnameText.Text = employee.Surname;
        labelJobtitleText.Text = employee.JobTitle;
        labelPhoneText.Text = employee.Phone;
        labelEmailText.Text = employee.Email;
        labelAddresText.Text = employee.Address;
    }


    private void CopyId(object sender, EventArgs e)
    {
        // Копирование текста в буфер обмена
        Clipboard.SetText(employee.Id.ToString());
    }


    private void change_selected_Id(object sender, EventArgs e)
    {
        mainController.choisedEmployee = employee;
    }


}
