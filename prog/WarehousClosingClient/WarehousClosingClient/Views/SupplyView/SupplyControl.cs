using Newtonsoft.Json.Linq;

using WarehousClosingClient.Controllers;
using WarehousClosingClient.Models;
namespace WarehousClosingClient.Views.SupplyView;

public partial class SupplyControl : UserControl
{
    private MainForm mainForm;

    public SupplyController supplyController;
    public ProviderController providerController;
    public SupplyCompaundController supplyCompaundController;
    public ProductController productController;
    public OrderCompaundController orderCompaundController;

    private SupplyAddController supplyAdd;

    public List<Supply> supply { get; set; }
    public Supply choisedSupply { get; set; }
    



    public SupplyControl(MainForm mainForm)
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
        choisedSupply = new Supply();

        supplyController = new SupplyController(mainForm.httpClient);
        supplyCompaundController = new SupplyCompaundController(mainForm.httpClient);
        providerController = new ProviderController(mainForm.httpClient);
        productController = new ProductController(mainForm.httpClient);
        orderCompaundController = new OrderCompaundController(mainForm.httpClient);

        supplyAdd = new SupplyAddController(this);
    }



    private void CallMenu(object sender, EventArgs e)
    {
        mainForm.ShowMenuControl();
    }



    public async void UpdateData()
    {
        flowLayoutPanel.Controls.Clear();
        
        supply = await supplyController.GetAllSupplyAsync();
        
        foreach (var item in supply)
        {
            flowLayoutPanel.Controls.Add(new SupplyRowControl(this, item));
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
        supplyAdd.InitializeData();
        groupBoxAction.Controls.Add(supplyAdd);
    }

    private void Edit(object? sender, EventArgs e)
    {
        if(choisedSupply.Id == Guid.Empty) { return; }
        groupBoxAction.Controls.Clear();
        groupBoxAction.Controls.Add(new SupplyEditController(this, choisedSupply));
    }

    
}
