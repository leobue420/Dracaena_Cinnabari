namespace _04._02._25._20_48;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("App running before the try block");
        try 
        {
            LevelOne();
        }
        catch(Exception ex)
        {
            Console.WriteLine($"Exeption Caught in Main: {ex.Message}");
        }
        Console.WriteLine("App still running");
        Console.WriteLine("Hello, World!");
        Console.ReadLine();
    }

    static void LevelOne()
    {
        Console.WriteLine("Level one before calling level two");
        LevelTwo();
        Console.WriteLine("Level one after calling level two");
    }

    static void LevelTwo()
    {
        Console.WriteLine("Level two before throw");
        throw new Exception("something went wrong level two active");
        Console.WriteLine("Level two after throw");
    }
}
