// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//int num = 0;

//Console.WriteLine($"num is {num}");

// num++;
// Console.WriteLine($"num is {num}");
// ++num;
// Console.WriteLine($"num is {num}");
// Console.WriteLine("num is {0}", ++num);
// Console.WriteLine("num is {0}", num++);
// Console.WriteLine("num is {0}", num);

// Console.WriteLine("num is {0}", --num);
// Console.WriteLine("num is {0}", num--);
// Console.WriteLine("num is {0}", num);


// num += 22;
// num -= 42;
// Console.WriteLine(num);
// num*= 42;
// num /= 33; 

// int num1 = 10;
// int num2 = 3;


// //modulo operator
// int result = num1%num2; // result =1

//creating an instance of the random class
Random random = new Random();
int randomNumber = random.Next( 1, 11 );

Console.WriteLine("guess a number");
string inputstring = Console.ReadLine();
int num1 = 0; 

bool isnumber = int.TryParse(inputstring, out num1);

if(isnumber)
{

    if(num1 == randomNumber)
    {
    Console.WriteLine("you guessed right!");
    }
    else
    Console.WriteLine("wrong, try again!");



}
else
Console.WriteLine("please enter only a number");


Console.ReadLine();