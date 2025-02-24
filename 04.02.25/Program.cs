using System.Diagnostics;

namespace _04._02._25;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter your age please");

        // GetUserAge(Console.ReadLine());
        try
        {
            int age = GetUserAge(Console.ReadLine());
            Console.WriteLine($"Your age is: {age}");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Age Error: " + ex.Message);
        }


        int result = 0;

        Debug.WriteLine("Main Method is running.");

        try
        {
        Console.WriteLine("please enter a number");
           //int num1 = 0;
        int num1 = Convert.ToInt32(Console.ReadLine());
        int num2 = 2;

        result = num2/num1;

        Console.WriteLine($"Result: {result}"); 
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("DON'T DIVIDE BY ZERO!!! Error:  " + ex.Message);
            Debug.WriteLine(ex.ToString());
        }
        catch (FormatException ex)
        {
            Console.WriteLine("PLEASE ENTER A NUMBER    Error:  " + ex.Message);
            Debug.WriteLine(ex.ToString());
        }
        // catch (OverflowException ex)
        // {
        //     Console.WriteLine("TOO BIG NUMBER   Error:  " + ex.Message);
        //     Debug.WriteLine(ex.ToString());
        // }
        catch (Exception ex) // This should be last
        {
            Console.WriteLine("Error:  " + ex.Message);
            Debug.WriteLine(ex.ToString());
        }
        finally 
        {
            Console.WriteLine("This always executes");

        }

        
        Console.WriteLine("Hello, World!");

        Console.ReadKey();
    }

             static int GetUserAge(string input)
        {
            int age;
            if(!int.TryParse(input, out age))
            {
                throw new Exception("you didnt enter a valid age.");
            }
            if(age < 0 || age > 120)
            {
                throw new Exception("your age must be verified, please upload all your personal information - deine Sozialpartei");
                

            }
            return age;
        }

}
