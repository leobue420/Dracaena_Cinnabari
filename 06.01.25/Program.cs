namespace _06._01._25;

using System.Runtime.CompilerServices;
using Cats;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Hello, World!");
        Cat Pusscat = new Cat("blue");
        Cat Bob = new Cat("green");

        Console.WriteLine("we have " + Cat.NumberofCats + " cats");

        Bob.RollinAround();

        Bob.readDetails();
        Pusscat.readDetails();

        Pusscat.Password = "löl";

        

        Console.ReadLine();
    }
}
