using System.Drawing;
using System.Security.Cryptography.X509Certificates;

namespace _16._02._25;

public struct Point
{
    // public int X {get; set;}
    // public int Y {get; set;}

    public int X;
    public int Y;

    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }

    public void Display()
    {

        Console.WriteLine($"Point is at X: {X} Y: {Y}");
    }

    public double DistanceTo(Point other)
    {
        double dx = other.X - X;
        double dy = other.Y - Y;
        return Math.Sqrt(dx * dx + dy * dy);

        
    }
}

class Program
{
    static void Main(string[] args)
    {
        Point p1 = new Point(10, 20);
        p1.Display();


        Point p2;
        p2.X = 20;
        p2.Y = 30;
        p2.Display();

        Point p3 = p1;
        p3.X = 50;
        p3.Display();

        double distance = p1.DistanceTo(p2);
        Console.WriteLine($"Distance between Points: {distance:F3}");

        Console.WriteLine("Hello, World!");
    }
}
