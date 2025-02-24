using System.Drawing;
using rectangle;

namespace _03._01._25._18_34;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Regtangle  R1 = new Regtangle();
        R1.Height = 5;
        R1.Width = 5;
        Console.WriteLine($"the area of R1 is {R1.Area}");
    }
}
