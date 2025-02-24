using System.ComponentModel;

namespace _13._01._25;



class Product
{
  public string Name{get; set;}

  public double Price{get; set;}

}

class Program
{
    static void Main(string[] args)
    {
        

        //a lambda expression consots of 2 parts:
        //1. parameters
        //2. Expression or statement block

        //Parameters are written on the left side of => 
        //the symbol reads a s goes to or becomes
        // the expression or action is on the right side

        //this reads as: 
        // take an input x and return it as x multiplied by x
        // x => x * x;


        //method out of this example
        // static int Squaring(int num1)
        // {
        //     return num1 * num1;
        // }

        List<Product> products = new List<Product>()
        {
            new Product{ Name = "Apple", Price = 3},
            new Product{ Name = "Pillow", Price = 4},
            new Product{ Name = "Oak Tree", Price = 20}
        };

        products.Add(new Product{Name = "Berries", Price = 1.50});

        Console.WriteLine("Available Products:");
        foreach (Product product in products)
        {
            Console.WriteLine($"Product name: {product.Name} for {product.Price}");
        }

       List<Product> cheapProducts = products.Where(p => p.Price > 10).ToList();
          foreach (Product product in cheapProducts)
        {
            Console.WriteLine($"Product name: {product.Name} for {product.Price}");
        }

        Console.WriteLine("Hello, World!");
        Console.ReadKey();


    }
}
