namespace _02._02._25;


class Program
{
    static void Main(string[] args)
    {

        var codes = new Dictionary<string, string>()
        {
            ["NY"] = "New YOrk",
            ["CA"] = "California",
            ["BER"] = "Berlin",
            ["HAM"] = "HAmburg",
            ["TX"] = "Texas"

        };


        if(codes.TryGetValue("NY", out string state))
        {
            Console.WriteLine(state);
        }

        Console.WriteLine("Hello, World!");

        foreach (var item in codes)
        {
            Console.WriteLine($"Code: {item.Key} name: {item.Value}");
        }
    }
}
