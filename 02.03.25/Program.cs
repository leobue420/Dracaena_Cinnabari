using System.Text.RegularExpressions;

namespace _02._03._25;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        string pattern = @"\d";
        Regex regex = new Regex(pattern);

        string text = "My number is 12345";

        MatchCollection matchCollection = regex.Matches(text);

        Console.WriteLine($"{matchCollection.Count} hits Found: {text}");

        foreach (Match hit in matchCollection)
        {
            GroupCollection group = hit.Groups;
            Console.WriteLine($"{group[0].Value} found at {group[0].Index}");
        }
    }
}
