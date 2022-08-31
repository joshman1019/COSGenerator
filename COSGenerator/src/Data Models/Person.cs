namespace COSGenerator; 

public class Person
{
    private string es = string.Empty; 

    public Person(string name, string address, string address2, string city, string state, string zip)
    {
        Name = name;
        Address = address;
        Address2 = address2;
        City = city;
        State = state;
        Zip = zip;
    }

    public string? Name { get; set; }
    public string? Address { get; set; }
    public string? Address2 { get; set; }
    public string? City { get; set; }
    public string? State { get; set; }
    public string? Zip { get; set; }
}