using System.Net.Security;

namespace _18._02._25._11_48;

class Program
{
    static void Main(string[] args)
    {
        int[] intArray = {1, 2, 3, 4, 5};
        string[] stringArray = {"hello", "world" };

        PrintArray(intArray);
        PrintArray(stringArray);


        Console.ReadKey();
        Console.WriteLine("Hello, World!");
    }

    // public static void PrintStringArray(string[] array )
    // {
    //     foreach(string item in array)
    //     {
    //         Console.WriteLine(item);
    //     }
    // }

    // public static void PrintIntArray(int[] array )
    // {
    //     foreach(int item in array)
    //     {
    //         Console.WriteLine(item);
    //     }
    // }


//a generic method that accepts a generic datatype
    public static void PrintArray<T>(T[] array)
    {
        foreach(T item in array)
        {
            Console.WriteLine(item);
        }
    }

}
