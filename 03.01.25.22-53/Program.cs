namespace _03._01._25._22_53;
using doubleit;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Your number is 10");
        doubleit thisnumberwillbedoubled = new doubleit(10);
        thisnumberwillbedoubled.timestwo(10);
        
        Console.WriteLine($"your result is: {Convert.ToString(thisnumberwillbedoubled.timestwo)}");

        // Console.WriteLine("your number is 10");
        // int number;
        // int result;

        // number = 10;
        // result = number*2;

        // Console.WriteLine($"your resulting number is {Convert.ToString(result)}");

        // was ne dumme aufgabe, kann man nicht als prüfung was geben was sch nur so lösen lässt? der dude hat keine kreativität

    }
}
