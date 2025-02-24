// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


string rocket = " .\n ..\n...";

for (int counter = 10; counter >= 0; counter--)
{
Console.Clear();
Console.WriteLine($"counter is {counter} \n{rocket}");
Thread.Sleep(1000);
rocket = "\n" + rocket;
}

Console.WriteLine("the rocket has landed!");