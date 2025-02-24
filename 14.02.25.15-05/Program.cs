namespace _14._02._25._15_05;

public class Hammer
{
    public void use()
    {
        Console.WriteLine("Hammering");
    }
}

public class Builder
{
    public Hammer _hammer;
    private Saw _saw;


    public Builder()
    {
        //builder is responsible for creating its dependencies
        _hammer = new Hammer();
        _saw = new Saw();
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
        Builder builder = new Builder();
        builder.BuildHouse();
        Console.WriteLine("Hello, World!");
    }
}
