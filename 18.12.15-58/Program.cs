// See https://aka.ms/new-console-template for more information

//methods are shaped like this:
// modifier returntype methodname(parameters) 
//{
//code block
//}


void myfirstmethod()
{
    Console.WriteLine("first method was called");
    Console.WriteLine("some super complicated code");
}
Console.WriteLine("this is outside of the method");

myfirstmethod();

Console.ReadKey();