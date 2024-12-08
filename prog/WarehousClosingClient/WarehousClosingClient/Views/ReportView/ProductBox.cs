using WarehousClosingClient.Models;

namespace WarehousClosingClient.Views.ReportView;

public partial class ProductBox : UserControl
{
    public Product product { get; set; }

    public int QuantitySupply { get; set; }
    public int QuantityOrder { get; set; }

    public ProductBox(Product product, int QuantitySupply, int QuantityOrder)
    {
        this.QuantityOrder = QuantityOrder;
        this.QuantitySupply = QuantitySupply;
        this.product = product;

        InitializeComponent();
        InitData();


    }

    private void InitData()
    {
        label2.Text = product.Name;
        label4.Text = product.Price.ToString("0.00");
        label6.Text = QuantitySupply.ToString();
        label8.Text = QuantityOrder.ToString();

        int temp = QuantitySupply - QuantityOrder;

        label9.Text = temp.ToString();

        if(temp > 0)
        {
            label9.ForeColor = Color.Green;
        }else if(temp == 0)
        {
            label9.ForeColor = Color.Yellow;
        }
        else
        {
            label9.ForeColor = Color.Red;
        }


    }



}
