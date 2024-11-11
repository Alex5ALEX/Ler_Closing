using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WarehouseClosingServer.Models;

public class OrderCompaund
{
    //atributs
    public int Quantity { get; set; } = 0;


    //links
    public Guid Id_Order { get; set; }

    public Order? Order { get; set; }


    public Guid Id_Product { get; set; }

    public Product? Product { get; set; }

    
}