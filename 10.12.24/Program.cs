// See https://aka.ms/new-console-template for more information
//Console.WriteLine("please enter a whole number!");


//int Rauru = int.Parse(Console.ReadLine());
//int Inka  = 22;

//Console.WriteLine($"the entered number is: {Rauru}");
//Console.WriteLine($"{Rauru} + {Inka} = { Rauru + Inka } ");

//int num1 = 42;
//int num2 = 187;
//int num3 = 200;
//int average = (num1 + num2 + num3) / 3;
//Console.WriteLine($"The average is: {average} ");

//int num1 = 10;
//int num2 = 20;
//int num3 = 30;
//int average = ((num1 + num2 + num3) / 3);
//Console.WriteLine("The average is: " + average);

using System.Net.Security;

var creb = ("🦀"); //char doesnt work here haha :(
var dawg = ("🐕");
var cet = ("🐈‍"); 
Console.WriteLine(creb);
Console.WriteLine(dawg);



// here something weird called string formatting, dunno why it exists
Console.WriteLine("this is a {0}, and this is a {1}, and this is a {2}", creb, dawg, cet );

string ok = ("this is a  \"string\" with: \na backslash \\ and a colon :");
Console.WriteLine(ok);

char mandala = '֎';
Console.WriteLine($"look, a mandala: {mandala}");
Console.WriteLine("Hello\n\tWorld");

Console.ReadLine();