namespace _16._02._25._14_34;

public struct Point
{
    public int X {get; set;}

     public int Y {get; set;}



    public Point(int x, int y)
    {
    X = x;
    Y = y;
    }

    public void Display()
    {
    Console.WriteLine($"Point: ({X},{Y})");
    }
}

public class PointClass
{
    public int X { get; set; }
    public int Y { get; set; }

    // Correct the constructor declaration
    public PointClass(int x, int y)
    {
        X = x;
        Y = y;
    }

    public void Display()
    {
        Console.WriteLine($"Point: ({X},{Y})");
    }

}



class Program
{
    static void Main(string[] args)
    {
        Point p1 =  new Point(10, 20);
        p1.Display();

        Point p2 = p1;
        p2.Display();
        p2.X = 25;
        Console.WriteLine("Changed p2 X to 25");
        p1.Display();
        p2.Display();

        Console.WriteLine("now the class objections");

        PointClass pC1 = new PointClass(1, 2);
        PointClass pC2 = pC1;
        pC1.Display();
        pC2.Display();

        pC2.X = 22;
        Console.WriteLine("Chnaged pc2 x to 22");
        pC1.Display();
        pC2.Display();

        bool IsEqual = pC1.Equals(pC2);
        Console.WriteLine($"is it equal? {IsEqual}");




        Console.ReadKey();
        Console.WriteLine("Hello, World!");
    }
}
