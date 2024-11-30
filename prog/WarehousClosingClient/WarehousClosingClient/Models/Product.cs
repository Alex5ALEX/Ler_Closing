namespace WarehousClosingClient.Models;

public class Product
{
    //atributs
    public Guid Id { get; set; }

    public string Name { get; set; } = String.Empty;

    public decimal Price { get; set; } = 0;


    //links
    public List<OrderCompaund> OrderCompaunds { get; set;} = [];

    public List<SupplyCompaund> SupplyCompaunds{ get; set;} = [];

}