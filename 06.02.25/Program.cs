using Microsoft.VisualBasic;

namespace _06._02._25;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Dog dog = new Dog();
        dog.Eat();
        dog.MakeSound();

        Cat Pusscat = new Cat();
        Pusscat.ShowFields();
        Pusscat.MakeSound();
        Pusscat.ShowCatsBrainIMeanAccessFieldsOOPS();

    }

}


// Base Class, Parent Class or SuperClass,
public class Animal
{
    public void Eat()
    {
        Console.WriteLine("Eating...");
    } 

    public string PublicString;
    protected string ProtectedString;

    private string PrivateString; // only accesible inside the class

    internal string InternalString;

    public void ShowFields()
    {
        Console.WriteLine($"Public: {PublicString} , Protected: {ProtectedString} , private: {PrivateString} , internal : {InternalString}");
    }

public virtual void MakeSound()
{
    Console.WriteLine("Animal makes generic sound");
}

}

class Cat : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Meooooow");

    }

    
 public void ShowCatsBrainIMeanAccessFieldsOOPS()
    {
        PublicString = "i am a cat";
        ProtectedString = "i am a protected cat because we are in an inherited/derived child class";
        //PrivateString = "Private cat, only accesible withing its own class";
        Console.WriteLine($"Public: {PublicString} , Protected: {ProtectedString} , private: Had to be deleted cause only accesible in its own class , internal : sadly not mentioned yet");
     }

   
}









//This is the derived class or child class or subclass
//The class inherits the sttributes of the higher class// Derived class, derived derived derived
public class Dog: Animal
{
    public override void MakeSound()
    {
        base.MakeSound();
        Console.WriteLine("Barking...");
    }
}

class Collie: Dog
{
    public void GoingNuts()
    {
        Console.WriteLine("Collie going Nuts");
    }
}
