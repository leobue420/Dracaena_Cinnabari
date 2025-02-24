namespace _16._02._25._17_48;

enum Day {mon, tue, wed, thu, fri, sat, sun};
enum Months{jan = 1, feb = 2, mar = 3, apr, may, jun, jul = 44, sep, oct, nov, dec};

class Program
{
    static void Main(string[] args)
    {
        Day Friday = Day.fri;
        Day Sunday = Day.sun;

        Day a = Friday;
        Console.WriteLine(Friday == a);
        Console.WriteLine(Day.mon);
        Console.WriteLine((int)Day.tue);
        Console.WriteLine((int)Months.apr);
        Console.WriteLine((int)Months.jul);

        Console.ReadKey();
        Console.WriteLine("Hello, World!");
    }
}
