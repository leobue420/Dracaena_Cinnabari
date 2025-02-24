namespace _18._02._25;

class Program
{

    //declaration of delegate can be outside of class as well, so we can declare it outside as well
    public delegate void Notify(string message);

    static void Main(string[] args)
    {

        // instantiation of a delegate
        Notify notifyDelegate = ShowMessage;
        // Notify notifyDelegate = new Notify(notifyDelegate); //this is old school


        //Invocation  of delegate
        notifyDelegate("Hello, Delegates");
        Console.WriteLine("Hello, World!");
    }

    static void ShowMessage(string message)
    {
        Console.WriteLine(message);
    }
    
}
