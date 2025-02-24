// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// void WriteSomething ()
// {
// Console.WriteLine("Write something");
// }

// WriteSomething();


// // a method that has the parameter mystring of sttring
// //method declaration
// void WriteSomethingSpecific( string myString )
// {
// Console.WriteLine($"you passed this argument to me {myString}");
// }

// string myUserName = "Bonoboss";

// //calling the method using an argument called "myusername"
// WriteSomethingSpecific(myUserName);

//RECHENPROJEKT

// int AddTwoValues(int value1, int value2)
// {
// int result = value1 + value2;
// return result;
// }

// Console.WriteLine("please enter num1");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("please enter num2");
// int num2 = Convert.ToInt32(Console.ReadLine());

// int myresult = AddTwoValues(num1,num2);
// Console.WriteLine($"The result is {myresult}");

// //FUNKTIONIERT

//SUBTRAKTION UND FUNFACT

int löl = 22;

int SubtractTwoValues(int value1, int value2)
{
int result = value1 - value2;
int otherResult = löl + result;
return result;
}

Console.WriteLine("please enter num1");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("please enter num2");
int num2 = Convert.ToInt32(Console.ReadLine());

int myresult = SubtractTwoValues(num1,num2);
Console.WriteLine($"The result is {myresult}");
Console.WriteLine($"The other result is {otherResult}");


Console.ReadLine();