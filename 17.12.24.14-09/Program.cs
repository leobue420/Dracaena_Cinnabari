// See https://aka.ms/new-console-template for more information
using System.Diagnostics.Metrics;

Console.WriteLine("Hello, World!");

// int number;

// //dowhile loop is a post test loop

// do
// {
//    Console.WriteLine("enter a positive whole number please");
//    number = Convert.ToInt32(Console.ReadLine());

// } while (number<=0);

int currentscore;
int sum = 0 ;
int Counter = 0;

do
{
Console.WriteLine("Enter your students score");
currentscore = Convert.ToInt32(Console.ReadLine());
if(currentscore != -1)
{ 
sum = sum + currentscore; 
Counter++;
}
} while (currentscore != -1);

int average = sum/Counter;

Console.WriteLine($"the average is {average}");

Console.ReadKey();
