// See https://aka.ms/new-console-template for more information
using System.Collections;

Console.WriteLine("Hello, World!");

int month = 5;
string monthname;


if(month == "January")
{
    monthname = "January";
}
else if(month == 2)
monthname = "February"; // one line else if statement



switch (month)
    {
    case 1:
    monthname = "January";
    break;
    case 2:
    monthname = "February";
    break;


    default: 
    monthname = "Unknown";
    break;
    }

int day = 1;
 switch (day)
               {
                 case 1:
                 Console.WriteLine("Monday");
                 break;
                case 2:
                Console.WriteLine("Tuesday");
                break;
                case 3:
                Console.WriteLine("Wednesday");
                break;
                
                default: 
                Console.WriteLine("another day");
                break;
                   
               }


