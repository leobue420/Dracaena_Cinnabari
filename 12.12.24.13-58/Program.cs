// See https://aka.ms/new-console-template for more information
using System.Data;

//Console.WriteLine("Enter the number of Holz and Wurm :");

int Holz, Wurm;

// var Holz = Console.ReadLine ; // you thought too easy

Console.WriteLine("Enter the number of Holz:");

if (!int.TryParse(Console.ReadLine(), out Holz))
{
Console.WriteLine("Invalid input for Holz. Please enter a valid integer.");
return;
}


// var testint = Console.ReadLine(), out testint; // so funktioniert out nicht, out funktioniert nur bei methoden, zb bei convert

// var Wurm = Console.ReadLine ; // you thought too simple

Console.WriteLine("Enter the number of Wurm:");
if (!int.TryParse(Console.ReadLine(), out Wurm))
{
Console.WriteLine("Invalid input for Wurm. Please enter a valid integer.");
return;
}


Console.WriteLine($"es gibt {Convert.ToString(Holz)} Holz und {Convert.ToString(Wurm)} Würmer");

// relational Operator
// other realtional Operators:  <= / < / > / >= / probaly = as well
//bool isHigher = Holz > Wurm;


if(Convert.ToInt32(Holz) >= Convert.ToInt32(Wurm) )
{
Console.WriteLine("Es gibt mehr Holz als Würmer");
}

Console.ReadKey();
