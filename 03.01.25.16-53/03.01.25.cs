namespace customer;
internal class customer
{
    public string Name { get; set; }
    public string Adress { get; set; }
    public string Contact { get; set; }


    // custom constructor

    public customer(string name, string adress, string contact)
    {
        Name = name;
        Adress = adress;
        Contact = contact;
    }

    public customer(string name)
    {Name = name; }
}