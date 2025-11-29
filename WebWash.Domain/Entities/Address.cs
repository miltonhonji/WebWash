namespace WebWash.Domain;

public class Address
{
    public int IdAddress { get; set; }
    public string Street { get; set; }
    public string Number { get; set; } //Em alguns bairros ainda há números e letras descrito no número da casa. 
    public string Neighborhood { get; set; }
    public int Complement { get; set; }
}
