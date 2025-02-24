namespace _03._01._25;
using customer;

class Program
{
    static void Main(string[] args)
    {
        customer earl = new customer("earl");

        earl.Name = "Earl";

        customer newCustomer = new customer();


    Console.WriteLine("Please enter the cutomers name");
        newCustomer.Name = Console.ReadLine();  

        customer FranktheTank = new customer("Frank", "Tank", "Tankhouse");
        Console.WriteLine($"The info of the customer is {newCustomer.Name}");

        customer RosieSchmosie = new customer("Rosie", "auf dem stuhl", "einaml mit der tüte knistern");
        Console.WriteLine($"{RosieSchmosie.Adress}, {RosieSchmosie.Name}, {RosieSchmosie.Contact}");

        customer PussWuschel = new customer();
        PussWuschel.SetDetails("Pussy","pinker Teppich");
        Console.WriteLine($"{PussWuschel.Name} ist hier: {PussWuschel.Adress} und erreichbar unter {PussWuschel.Contact}");


    Console.WriteLine(AddNum(15,25));
    Console.WriteLine(AddNum(firstNum: 2, secondNum: 1));
    Console.WriteLine(AddNum(2, secondNum: 2));
    Console.WriteLine(AddNum(firstNum:2,2));

    customer Friedo = new customer();
    Friedo.SetDetails("Friedo", "im Schnee", "an der tür");
    Console.WriteLine($"{Friedo.Name},{Friedo.Adress},{Friedo.Contact}");
    // customer.DoingStuff();

    //the doingstuff method is static and cannot be called on objects

    itsSnowing(); //callale because its static look down

    Program nunRegnets = new Program();
    nunRegnets.Regen();// works and is callable because it is not public or static and only there

    customer Notebook = new customer();
    Console.WriteLine($"{Notebook.Name} , {Notebook.Adress}, {Notebook.Contact}");


    }
    static int AddNum(int firstNum, int secondNum)
    {
        return firstNum + secondNum;
    }

    public static void itsSnowing()
    {
        Console.WriteLine("its snowing");
    }

    // in c# the static keyword is used to declare members of a class that belong to the
    // class itself rather than to any specific instance of the class

  void Regen()
    {
        Console.WriteLine("es regnet");
    }

}
