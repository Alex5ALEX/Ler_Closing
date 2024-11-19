using WarehousClosingClient.Views.CustomerView;
using WarehousClosingClient.Views.EmployeeView;
using WarehousClosingClient.Views.OrderView;
using WarehousClosingClient.Views.ProductView;
using WarehousClosingClient.Views.ProviderView;
using WarehousClosingClient.Views.SupplyView;



namespace WarehousClosingClient
{
    public partial class Form1 : Form
    {
        private CustomerControl _customerControl;
        private EmployeeControl _employeeControl;
        private OrderControl    _orderControl;
        private ProductControl  _productControl;
        private ProviderControl _providerControl;
        private SupplyControl   _supplyControl;


        public Form1()
        {
            InitializeComponent();

           


            // закрытие оп нажатию дефолтной кнопки
            this.FormClosing += new FormClosingEventHandler(Form_FormClosing);




            //определение layout-ов
            _customerControl = new CustomerControl();
            _employeeControl = new EmployeeControl();
            _orderControl = new OrderControl();
            _productControl = new ProductControl();
            _providerControl = new ProviderControl();
            _supplyControl = new SupplyControl();



            //работа с кнопками
            customerMenu.Click +=   View_Customer;
            employeeMenu.Click +=   View_Employee;
            orderMenu.Click +=      View_Order;
            productMenu.Click +=    View_Product;
            supplyMenu.Click +=     View_Supply;
            providerMenu.Click +=   View_Provider;

        }


        private void View_Customer(object sender, EventArgs e)
        {
            groupBox_View.Controls.Clear();

            groupBox_View.Controls.Add(_customerControl);
        }

        private void View_Employee(object sender, EventArgs e)
        {
            groupBox_View.Controls.Clear();

            groupBox_View.Controls.Add(_employeeControl);
        }

        private void View_Order(object sender, EventArgs e)
        {
            groupBox_View.Controls.Clear();

            groupBox_View.Controls.Add(_orderControl);
        }
        private void View_Product(object sender, EventArgs e)
        {
            groupBox_View.Controls.Clear();

            groupBox_View.Controls.Add(_productControl);
        }

        private void View_Supply(object sender, EventArgs e)
        {
            groupBox_View.Controls.Clear();

            groupBox_View.Controls.Add(_supplyControl);
        }

        private void View_Provider(object sender, EventArgs e)
        {
            groupBox_View.Controls.Clear();

            groupBox_View.Controls.Add(_providerControl);
        }









        //метод для закрытия окна
        private void Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены, что хотите закрыть приложение?", "Подтверждение", MessageBoxButtons.YesNo);

            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
