namespace _02._02._25._10_47;

class Program
{
    static void Main(string[] args)
    {

        

        
        Console.WriteLine("Hello, World!");
        int result = 0;
        try
        {
          

        Console.WriteLine("Please enter a number");
        int num1 = 0;
        int num2 = 2;

        result = num2/num1; 
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }

        Console.WriteLine($"Result: {result}");

        Console.ReadKey();
    }
}
