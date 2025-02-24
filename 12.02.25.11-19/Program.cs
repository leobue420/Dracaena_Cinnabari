namespace _12._02._25._11_19;

public class Animal
{
    public virtual void MakeSound()
    {
        Console.WriteLine("Animal Specific Sound");
    }
}

public class Dog : Animal
{
    public override void MakeSound()
    {
       Console.WriteLine("Bark");
    }
}

public class Cat : Animal
{
    public override void MakeSound()
    {
       Console.WriteLine("meow");
    }
}

class Program
{
    static void Main(string[] args)
    {

        Animal myCat = new Cat();
        myCat.MakeSound();
        Console.WriteLine("Hello, World!");
        Console.ReadKey();
    }
}
