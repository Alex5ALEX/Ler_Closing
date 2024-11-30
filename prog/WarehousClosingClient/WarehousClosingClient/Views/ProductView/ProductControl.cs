using Newtonsoft.Json.Linq;

using WarehousClosingClient.Controllers;
using WarehousClosingClient.Models;
namespace WarehousClosingClient.Views.ProductView;

public partial class ProductControl : UserControl
{
    private MainForm mainForm;
    public  ProductController productController;
    private ProductAddController productAdd;

    public List<Product> products { get; set; }
    public Product choisedProduct { get; set; }




    public ProductControl(MainForm mainForm)
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
        choisedProduct = new Product();
        productController = new ProductController(mainForm.httpClient);
        productAdd = new ProductAddController(this);
    }



    private void CallMenu(object sender, EventArgs e)
    {
        mainForm.ShowMenuControl();
    }



    public async void UpdateData()
    {
        flowLayoutPanel.Controls.Clear();

        products = await productController.GetAllProductsAsync();

        foreach (var product in products)
        {
            flowLayoutPanel.Controls.Add(new ProductRowControl(this, product));
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
        groupBoxAction.Controls.Add(productAdd);
    }

    private void Edit(object? sender, EventArgs e)
    {
        if (choisedProduct.Id == Guid.Empty) { return; }

        groupBoxAction.Controls.Clear();
        groupBoxAction.Controls.Add(new ProductEditController(this,choisedProduct));
    }


}
