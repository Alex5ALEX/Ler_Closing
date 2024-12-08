using WarehousClosingClient.Views.SupplyView.Rows;
using WarehousClosingClient.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WarehousClosingClient.Views.SupplyView;

public partial class SupplyAddController : UserControl
{

    private SupplyControl mainController;
    private List<ProductShortRow> productRow { get; set; } = [];
    private List<ProviderShortRow> providerRow {  get; set; } = [];


    public Provider choisedProvider { get; set; } = new Provider();



    public SupplyAddController(SupplyControl mainController)
    {
        this.mainController = mainController;

        InitializeComponent();
        InitData();


        buttonBack.Click += Back;
        buttonAdd.Click += AddItem;
    }


    private void Back(object? sender, EventArgs e)
    {
        mainController.HideActionGroupBox();
    }



    public async void InitData()
    {
        InitProducts();
        InitProviders();
    }



    public async void InitProducts()
    {
        flowLayoutPanelProducts.Controls.Clear();
        productRow.Clear();

        var products = await mainController.productController.GetAllProductsAsync();

        foreach (var item in products)
        {
            var token = new ProductShortRow(item);
            productRow.Add(token);
            flowLayoutPanelProducts.Controls.Add(token);
        }
    }



    public async void InitProviders()
    {
        flowLayoutPanelProviders.Controls.Clear();
        productRow.Clear();

        var providers = await mainController.providerController.GetAllProvidersAsync();


        foreach(var provider in providers)
        {
            var token = new ProviderShortRow(this, provider);
            providerRow.Add(token);
            flowLayoutPanelProviders.Controls.Add(token);
        }

    }



    //action

    public void ShowProvider()
    {
        label1.Text = choisedProvider.Company;
        label2.Text = choisedProvider.ContactPerson;
        label3.Text = choisedProvider.Phone;
        label4.Text = choisedProvider.Email;
    }


    private async void AddItem(object? sender, EventArgs e)
    {
        //проверка что пользователь ввел все поля
        if (choisedProvider.Id == Guid.Empty)
        {
            MessageBox.Show("Пожалуйста, выберите поставщика.");
            return;
        }




        decimal price = 0;

        if (!decimal.TryParse(textBoxPrice.Text, out price))
        {
            MessageBox.Show("Цена введена не корректно.");
            return;
        }


        Supply supply = new Supply()
        {
            Id = Guid.NewGuid(),
            Date = dateTimePicker.Value,
            Price = price,
            Id_Provider = choisedProvider.Id
        };


        var response = await mainController.supplyController.PostSupply(supply);

        if (!response.IsSuccessStatusCode)
        {
            return;
        }

        foreach (var item in productRow)
        {
            if (item.GetQuantity() > 0)
            {
                SupplyCompaund compaund = new SupplyCompaund()
                {
                    Id_Supply = supply.Id,
                    Id_Product = item.product.Id,
                    Quantity = item.GetQuantity()
                };


                var responseCompaund = await mainController.supplyCompaundController.PostSupplyCompaund(compaund);

                if (responseCompaund.IsSuccessStatusCode) { continue; }

            }
        }



        dateTimePicker.Value = DateTime.Now;
        choisedProvider = new Provider();
        ShowProvider();
        textBoxPrice.Text = string.Empty;
        InitData();
        mainController.UpdateData();
        
    }



}
