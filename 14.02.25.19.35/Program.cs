namespace _14._02._25._19._35;

public class Hammer
{
    public void use()
    {
        Console.WriteLine("Hammering");
    }
}

public class Builder : IToolUser
{
    private Hammer _hammer;
    private Saw _saw;


    

    public void BuildHouse()
    {
        _hammer.use();
        _saw.Use();
        Console.WriteLine("House built");
    }

     public void SetHammer(Hammer hammer)
    {
        _hammer = hammer;
    }

    public void SetSaw(Saw saw)
    {
        _saw = saw;
    }
}

public interface IToolUser
{
}

public class Saw
{
    public void Use()
    {
        Console.WriteLine("Sawing");
    }
}

class Program
{
    static void Main(string[] args)
    {

        Hammer Hammer = new Hammer();
        Saw Saw = new Saw();
        Builder Builder = new Builder();
        Builder.SetHammer(Hammer);
        Builder.SetSaw(Saw);

        // injected dependencies via setters

        Builder.BuildHouse();
        Console.WriteLine("Hello, World!");


    }
}

