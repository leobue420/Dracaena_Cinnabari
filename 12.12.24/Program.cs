// See https://aka.ms/new-console-template for more information
using System.Runtime.InteropServices.Marshalling;

Console.WriteLine("Hello, World!");


bool cloudySky = true;
bool warmCLothes = true;
bool insideAWarmHouse = true;

// if(cloudySky && warmCLothes ) 
//booleans are useful for if statements cause when they are true the code will be executed, if they are not true nothing happens
// {
// Console.WriteLine("its cloudy and probably cold :( \n im warm anyways, lucky ");
// Console.WriteLine("im warm anyways, lucky");

// }

//logical operators: 
// and &&
// or ||
// not ! 

if(!cloudySky || warmCLothes || insideAWarmHouse )
// when you add ! it doesnt matter if its true or not in the definition, its being forced to always be negative (wonder if you dont even need to define it anymore)
// if this or that is true then execute, thats what the logic says
{
Console.WriteLine("im warm");
}
Console.WriteLine("okayyyy...");


Console.ReadKey();

//variants of or statements 
// true || true --> true 
// true || false --> true 
// false || true --> true
// false || false -->  false

//variants of the AND operator
// true && true --> true 
// true && false -->  false
// false && true --> false
// false && false -->  false