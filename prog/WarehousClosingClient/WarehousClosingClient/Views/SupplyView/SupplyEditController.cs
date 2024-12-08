using WarehousClosingClient.Views.SupplyView.Rows;
using WarehousClosingClient.Models;
namespace WarehousClosingClient.Views.SupplyView;

public partial class SupplyEditController : UserControl
{
    private SupplyControl mainController;
    private Supply supply;

    private List<SupplyCompaund> supplyCompaundRow { get; set; } = [];
    private List<ProductShortRow> productRow { get; set; } = [];
    private List<ProviderShortRow> providerRow { get; set; } = [];


    public Provider choisedProvider { get; set; }


    public SupplyEditController(SupplyControl mainController, Supply supply)
    {
        this.mainController = mainController;
        this.supply = supply;

        InitializeComponent();
        InitData();


        buttonBack.Click += Back;
        buttonEdit.Click += Edit;
        buttonDelete.Click += Delete;
    }




    private void Back(object? sender, EventArgs e)
    {
        mainController.HideActionGroupBox();
    }


    private async void InitData()
    {
        dateTimePicker.Value = supply.Date;
        textBoxPrice.Text = supply.Price.ToString();

        choisedProvider = await mainController.providerController.GetProviderById(supply.Id_Provider);
        ShowProvider();

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

        supplyCompaundRow = await mainController.supplyCompaundController.GetSupplyCompaundByIdSupply(supply.Id);

        foreach (var item in supplyCompaundRow)
        {
            foreach (var productline in productRow)
            {
                if (productline.product.Id == item.Id_Product)
                {
                    productline.SetQuantity(item.Quantity);
                }

            }
        }

    }



    public async void InitProviders()
    {
        flowLayoutPanelProviders.Controls.Clear();
        productRow.Clear();

        var providers = await mainController.providerController.GetAllProvidersAsync();


        foreach (var provider in providers)
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



    private async void Edit(object? sender, EventArgs e)
    {
        
        //проверка что пользователь ввел все поля
        if (string.IsNullOrWhiteSpace(textBoxPrice.Text))
        {
            MessageBox.Show("Пожалуйста, заполните все поля.");
            return;
        }

        decimal price = 0;

        if (!decimal.TryParse(textBoxPrice.Text, out price))
        {
            MessageBox.Show("Цена введена не корректно.");
            return;
        }


        supply.Date = dateTimePicker.Value;
        supply.Id_Provider = choisedProvider.Id;
        supply.Price = price;


        foreach (var item in productRow)//List<ProductAddRowControl>
        {
            bool temp1 = false;

            foreach (var temp in supplyCompaundRow)//List<SupplyCompaund>
            {

                if (item.product.Id == temp.Id_Product)
                {

                    if (item.GetQuantity() != temp.Quantity)
                    {
                        temp.Quantity = item.GetQuantity();
                        mainController.supplyCompaundController.PutSupplyCompaund(temp);
                    }
                }
            }
            if(temp1 == false)
            {
                if(item.GetQuantity() > 0)
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

        }


        InitData();
        mainController.UpdateData();
        
    }

    

    private void Delete(object? sender, EventArgs e)
    {
        DialogResult result = MessageBox.Show("Are you sure want to delete?", "", MessageBoxButtons.YesNo);

        if (result == DialogResult.No){return;}


        var response = mainController.supplyController.DelSupply(supply);

        foreach (var item in supplyCompaundRow)
        {
            mainController.supplyCompaundController.DelSupplyCompaund(item);
        }


        if (response.Result.IsSuccessStatusCode)
        {
            mainController.UpdateData();
            Back(sender, e);
        }
    }
    
}
