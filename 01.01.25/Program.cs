using System.Security.AccessControl;
using blob;

namespace _01._01._25;

class Program
{
    static void Main(string[] args)
    {
         //creating an object of the class car
        //creating an instace of the class car

        Car Pusscat = new Car("Ragdoll", "1", true);
        Car Friedo = new Car("Europäisch Kurzhaar", "3", false);
        Console.ReadKey();
        Console.WriteLine("Hello, World!");


        Console.WriteLine("Pelase enter the car age");
        Pusscat.Age = Console.ReadLine();

        Console.WriteLine($"you entered {Pusscat.Model} is {Pusscat.Age} years old");

        //trying out luxury

        Console.WriteLine($"the breed is {Pusscat.Model}");

        Console.WriteLine($"the breed is {Friedo.Model}");

       // Pusscat._model =""; -> sowas wird nicht gemacht, das ist schlechtes programmieren
    }
}
