namespace WebWash.Domain;

public class Customer : Base
{
    public string Telephone { get; set; }
    public string Cellphone { get; set; }
    public string Document { get; set; }
    public Address Address { get; set; }
    public string Observations { get; set; }
}
