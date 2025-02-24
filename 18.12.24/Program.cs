// See https://aka.ms/new-console-template for more information
using System.Reflection;

Console.WriteLine("Hello, World!");


// for (int i = 0; i < 10; i++)
// {
//     Console.WriteLine(i);
//     if(i == 3 )
//     {
//         Console.WriteLine("ive had enough");
//         //break;
//         continue; // continue ist als ob man den schritt im loop skippen würde
//     }
//     Console.WriteLine(i);
// }

// int num1 = 0;
// int num2 = 0;
// int num3 = 0;
// int num4 = 0;
// int num5 = 0;

//declare an array
// int[] myIntArray = new int[5];

// myIntArray[0] = 5;
// myIntArray[1] = 12;
// myIntArray[2] = 13;
// myIntArray[3] = 14;
// myIntArray[4] = 15;

// Console.WriteLine(myIntArray[0]);


// int[] myIntArray = [0,1,2,3,4];

// string[] myWeekDays = ["Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"];

// Console.WriteLine(myWeekDays.Length);

// // for (int i = 0; i < myWeekDays.Length; i++)
// // {
// //     Console.WriteLine(myWeekDays[i]);
// // }


// //foreach is good for iterating through a collection of items
// foreach (var item in myWeekDays )
// {
//     Console.WriteLine(item);
// }

// Console.WriteLine($"Today is {myWeekDays[0]} ");
// Console.WriteLine($"Today is {myWeekDays[1]} ");
// Console.WriteLine($"Today is {myWeekDays[2]} ");
// Console.WriteLine($"Today is {myWeekDays[3]} ");
// Console.WriteLine($"Today is {myWeekDays[4]} ");
// Console.WriteLine($"Today is {myWeekDays[5]} ");
// Console.WriteLine($"Today is {myWeekDays[6]} ");


//MULTI DIMENSIONAL ARRAYS

// int[,] array2DDeclaration = new int[0,0]; // hier wurde nichts assigned, hat nichts mit array2dinitialized zu tun

// int[,,] array3DDeclaration = new int[3,3,3];

// int[,] array2DInitialized = {{1,2},{3,4},{5,6}};

//array2DInitialized[0,0] = 5;

//Console.WriteLine(array2DInitialized[1,0]);

// string[,,] array3dstring =
// { { {"000","001"}, {"010","011"}, }, {{"100","101"}, {"110", "111"}, }};


int[] numbers = [1,2,3,4,5];

//Console.WriteLine($"{numbers[0]}\n{numbers[1]}\n{numbers[2]}\n{numbers[3]}\n{numbers[4]}\n");

foreach (var item in numbers)
{
    Console.WriteLine(item);
}


Console.ReadKey();