﻿namespace _17._02._25;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ceiling: " + Math.Ceiling(15.3));
        Console.WriteLine("Floor: " + Math.Floor(15.3));

        int num1 = 13;
        int num2 = 9;
        Console.WriteLine($"The lower of {num1} and {num2} is {Math.Min(num1, num2)}");
        Console.WriteLine($"The higher of {num1} and {num2} is {Math.Max(num1, num2)}");

        Console.WriteLine($"3 to the power 5 is {Math.Pow(3,5)}");
        Console.WriteLine($"Pi is:  {Math.PI}");

        Console.WriteLine($"The squareRoot from 25 is:  {Math.Sqrt(25)}");
        Console.WriteLine($"Always positive is:  {Math.Abs(-42)}");
        Console.WriteLine($"cos of 1:  {Math.Cos(1)}");



        Console.WriteLine("Hello, World!");
    }
}
