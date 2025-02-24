// See https://aka.ms/new-console-template for more information
using System.Security.Cryptography;

Console.WriteLine("Please enter a number");


int num1 = 0;
int num2 = 0;

bool isEqual = num1 == num2;

bool isNotEqual = num1 != num2;

if(num1 == int.Parse(Console.ReadLine()))
{
Console.WriteLine("numbers are equal");

    Console.WriteLine("please enter your age");
    int age = int.Parse(Console.ReadLine());
    if(age <= 18)
    {

    Console.WriteLine("please dont get groomed, okay? (only answer with yes or no)");
    var Answer1 = Console.ReadLine();
    Console.WriteLine($"the user answered with {Answer1}");
    }
    else
    {
        Console.WriteLine("lolololol, random random");
    }

}
else
{
    Console.WriteLine("numbers are not equal");
}