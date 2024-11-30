using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WarehousClosingClient.Models;

public class SupplyCompaund
{
    //atributs
    public int Quantity { get; set; } = 0;


    //links
    public Guid Id_Supply {  get; set; }

    public Supply? Supply { get; set; }



    public Guid Id_Product { get; set; }

    public Product? Product { get; set; }

}
