namespace WarehousClosingClient.Models;

public class Order
{
    //atributs
    public Guid Id { get; set; }

    public DateTime Date { get; set; } = DateTime.Now;


    //links
    public Guid Id_Customer { get; set; }

    public Customer? Customer { get; set; }

    public Guid Id_Employee { get; set; }  

    public Employee? Employee { get; set; }

    public List<OrderCompaund> OrderCompaunds { get; set; } = [];
}