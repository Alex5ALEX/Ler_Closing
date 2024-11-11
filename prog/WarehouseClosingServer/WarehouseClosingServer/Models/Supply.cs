namespace WarehouseClosingServer.Models;

public class Supply
{
    //atributs
    public Guid Id { get; set; }
   
    public DateTime Date { get; set; } = DateTime.Now;

    public decimal Price { get; set; } = 0;


    //links
    public Guid Id_Provider { get; set; }

    public Provider? Provider { get; set; }

    public List<SupplyCompaund> SupplyCompaunds { get; set; } = [];

}