using System.Dynamic;

namespace _12._01._25;


class Product
{
  public string Name{get; set;}

  public string Price{get; set;}

}

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int> {10, 8, 55, 22, 9, 25, 3, 11}; 

        Console.WriteLine("unsorted  list:");
        foreach (int number in numbers)
        {
           Console.WriteLine(number); 
        }




    numbers.Sort();
   Console.WriteLine("sorted  list:");
        foreach (int number in numbers)
        {
           Console.WriteLine(number); 
        }


    //this will return a list of numbers that are 10 and higher
    List<int> higherEqualTen = numbers.FindAll(x => x >=  10);
    Console.WriteLine("All numbers 10 and higher in our List");
     foreach (int number in higherEqualTen)
        {
           Console.WriteLine(number); 
        }



   Predicate<int> IsGreaterTen = IsGreaterThanTen;

  // alternativ geht auch: Predicate<int> IsGreaterTen = x => x > 10;


   List<int> higherTen = numbers.FindAll(IsGreaterTen);
   Console.WriteLine("Liste an Zahlen die größer als 10 sind.");
   foreach (int number in higherTen)
   {
      Console.WriteLine(number);
   }


bool hasLargeNumber = numbers.Any(x => x > 20);

if (hasLargeNumber)
{
   Console.WriteLine("THEre are Large numbers");
}
else
Console.WriteLine("THere arre no large numbers");


        Console.WriteLine("Hello, World!");
        Console.ReadKey();






    }



   public static bool IsGreaterThanTen(int x)
   {
      return x > 10;
   }


}


