using WarehousClosingClient.Models;

namespace WarehousClosingClient.Views.ReportView;

public partial class QuantityControl : UserControl
{
    private ReportControl mainController;

    private List<Product> products { get; set; } = [];

    public QuantityControl(ReportControl mainController)
    {
        this.mainController = mainController;


        InitializeComponent();
        InitData();

    }

    private async void InitData()
    {
        products = await mainController.productController.GetAllProductsAsync();

        foreach (Product product in products)
        {
            int QuantitySupply = 0;
            int QuantityOrder = 0;

            List<SupplyCompaund> supcomp = await mainController.supplyCompaundController.GetSupplyCompaundByIdProduct(product.Id);

            foreach (var sup in supcomp) { QuantitySupply += sup.Quantity; }


            List<OrderCompaund> ordcomp = await mainController.orderCompaundController.GetOrderCompaundByIdProduct(product.Id);

            foreach (var ord in ordcomp) {  QuantityOrder += ord.Quantity; } 

            flowLayoutPanel1.Controls.Add(new ProductBox(product,QuantitySupply,QuantityOrder));
        }


    }



}
