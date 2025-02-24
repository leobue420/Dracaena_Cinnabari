using System.Data.Common;

namespace _12._02._25;


public interface IAnimal
{
    void MakeSound();
    void IEat(string Food);
}

public class Cat : IAnimal
{
    public void IEat(string Food)
    {
        Console.WriteLine($"Cat ate {Food}");
    }

    public void MakeSound()
    {
        Console.WriteLine($"Meow");
    }
}

public class Rabbit : IAnimal
{
    public void IEat(string Food)
    {
        Console.WriteLine($"Rabbit ate {Food}");
    }

    public void MakeSound()
    {
        Console.WriteLine($"Thump thump, squeaaak, grunt");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        Cat Pusscat = new Cat();
        Pusscat.IEat("Grass");
        Pusscat.MakeSound();

        Rabbit Oster = new Rabbit();
        Oster.IEat("Carrot");
        Oster.MakeSound();
        

        Console.ReadKey();
    }


    
}
