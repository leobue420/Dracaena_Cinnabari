using System.Reflection.Metadata;

namespace customer;
internal class customer
{
    public string Name { get; set; }
    public string Adress { get; set; }
    public string Contact { get; set; }


    // custom constructor

    // public customer(string name, string adress, string contact)
    // {
    //     Name = name;
    //     Adress = adress;
    //     Contact = contact;
    // }


//default/optinal parameter, contact number and adress
    public customer(string name, string adress = "NA", string contact = "NA")
    {
        Name = name;
        Adress = adress;
        Contact = contact;
        //SetDetails(name, adress); 
        //sowas geht nur in der datei selbst da es ja sonst immer x.setdetail ist
    }

    //default constructor

    public customer()
    {
        Name = "New Customer";
        Adress = "not existent";
        Contact = "not existent";
    }

    public customer(string name)
    {Name = name; }


//default parameter contact number
    public void SetDetails(string name, string adress, string contact = "Not Available")
    {
        // Name = name;
        // Adress = adress;
        // Contact = contact;
    }

    // public static void DoingStuff()
    // {
    //     Console.WriteLine("Eating, drinking, breathing, pooping");
    // }
}