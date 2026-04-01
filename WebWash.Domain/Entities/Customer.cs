namespace WebWash.Domain;

public class Customer : BaseEntity
{
    public string Telephone { get; set; }
    public string Cellphone { get; set; }
    public string Document { get; set; }
    public List<Address> Addresses { get; set; }
    public string Observations { get; set; }
}
