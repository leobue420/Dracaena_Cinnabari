using System.Security.AccessControl;
using blob;

namespace _03._01._25._16_53;

class Program
{
    static void Main(string[] args)
    {
    Car Puss = new Car("Ragdoll", "1", true);
    Puss.Rollin();

    Car Bob = new Car ("Europäisch Kurzhaar","6", false);
    Bob.Rollin();

    Console.WriteLine();

    }
}
