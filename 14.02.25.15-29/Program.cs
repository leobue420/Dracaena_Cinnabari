namespace _14._02._25._15_29;

public class Hammer
{
    public void use()
    {
        Console.WriteLine("Hammering");
    }
}

public class Builder
{
    private Hammer _hammer;
    private Saw _saw;


    public Builder(Hammer hammer, Saw saw)
    {
        //Constructor injection
        _hammer = hammer;
        _saw = saw;
    }

    public void BuildHouse()
    {
        _hammer.use();
        _saw.Use();
        Console.WriteLine("House built");
    }
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

        Hammer hammer = new Hammer();
        Saw saw = new Saw();
        Builder builder = new Builder(hammer, saw);

        builder.BuildHouse();

        Console.WriteLine("Hello, World!");
    }
}

