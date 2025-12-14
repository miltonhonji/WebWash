namespace WebWash.Domain;

public class Order
{
    public int IdOrder { get; set; }
    public int IdCustomer { get; set; }
    public DateTime EntryDate { get; set; }
    public DateTime WithdrawDate { get; set; }
    public EOrderStatus OrderStatus { get; set; }
}
