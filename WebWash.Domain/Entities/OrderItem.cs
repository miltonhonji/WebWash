namespace WebWash.Domain;

public class OrderItem : BaseEntity
{
    public int IdOrder { get; set; }
    public Order Order { get; set; }
    public int IdServiceType { get; set; }
    public ServiceType ServiceType { get; set; }
    public int Quantity { get; set; }
    public decimal UnitPrice { get; set; }
    public decimal SubTotal => Quantity * UnitPrice;
}
