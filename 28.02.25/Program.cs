using System.Text.RegularExpressions;

namespace _28._02._25;

class Program
{
    static void Main(string[] args)
    {
        // Phone number validation
        Console.WriteLine("Please enter a number in one of these formats:");
        Console.WriteLine("- Domestic: 0171/1234567 (any mobile prefix)");
        Console.WriteLine("- International: +491721234567 (any mobile prefix)");
        string phoneNumber = Console.ReadLine();
        
        // Updated pattern explanation:
        // ^              - Start of string
        // (              - Start of group with two alternatives
        //   0[1-9][0-9]{1,2}\\/[0-9]+  - Domestic: 0 followed by 1-9, then 1-2 digits, slash, then any number of digits
        //   |            - OR
        //   \+49[1-9][0-9]{1,2}[0-9]+  - International: +49 followed by 1-9, then 1-2 digits, then any number of digits
        // )              - End of group
        // $              - End of string
        string pattern = @"^(0[1-9][0-9]{1,2}\\/[0-9]+|\+49[1-9][0-9]{1,2}[0-9]+)$";
        
        bool isMatch = Regex.IsMatch(phoneNumber, pattern);

        if (isMatch)
        {
            Console.WriteLine("Valid phone number format!");
        }
        else
        {
            Console.WriteLine("Invalid phone number format.");
            Console.WriteLine("Please use either 0xxx/xxxx... or +49xxx.... format (x = digits).");
        }

        Console.WriteLine(); // Empty line for better readability

        // Name validation (unchanged)
        Console.WriteLine("Please enter a name in one of these formats:");
        Console.WriteLine("- Mr. Müller");
        Console.WriteLine("- Ms Schmidt");
        Console.WriteLine("- Mrs. K.");
        string name = Console.ReadLine();
        
        string pattern2 = @"^(Mr|Ms|Mrs)\.?\s[A-ZÄÖÜ][a-zäöüß]*(\.?)?$";
        
        bool isMatch2 = Regex.IsMatch(name, pattern2);

        if (isMatch2)
        {
            Console.WriteLine("Valid name format!");
        }
        else
        {
            Console.WriteLine("Invalid name format.");
            Console.WriteLine("Please use Mr/Ms/Mrs followed by a name starting with a capital letter.");
        }

          Console.WriteLine(); // Empty line for better readability

        // Website/URL validation
        Console.WriteLine("Please enter a website URL in one of these formats:");
        Console.WriteLine("- www.example.com");
        Console.WriteLine("- x.com/i/grok");
        Console.WriteLine("- https://subdomain.example.co.uk/path");
        string website = Console.ReadLine();
        
        // Pattern explanation:
        // ^                     - Start of string
        // (                     - Start of group
        //   (https?:\/\/)?      - Optional http:// or https://
        //   (                   - Domain group
        //     (x\.com           - Specifically allow x.com
        //     |                 - OR
        //     [a-zA-Z0-9-]+(\.[a-zA-Z0-9-]+)+) - Other domains
        //   )                   - End domain group
        //   (\/[a-zA-Z0-9-_\/]+)? - Optional path
        // )                     - End main group
        // $                     - End of string
        string pattern3 = @"^((https?:\/\/)?((x\.com|[a-zA-Z0-9-]+(\.[a-zA-Z0-9-]+)+))(\/[a-zA-Z0-9-_\/]+)?)$";
        
        bool isMatch3 = Regex.IsMatch(website, pattern3);

        if (isMatch3)
        {
            Console.WriteLine("Valid website URL format!");
        }
        else
        {
            Console.WriteLine("Invalid website URL format.");
            Console.WriteLine("Please use a valid domain (e.g., example.com, x.com) with optional path.");
        }


        Console.ReadLine(); // Keep console open to view results
    }
}