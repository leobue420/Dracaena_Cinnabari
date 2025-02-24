// See https://aka.ms/new-console-template for more information
//Console.WriteLine("enter a number");

//console.WriteLine("enter a whole number please!");


//int mynumber = 0; //mynumber is an integer and has an asssigned value of 0 rn
//string userinput = Console.ReadLine(); //userinput is a string(text) and is defined in the console where it reads the value and assigns it
//mynumber = int.Parse(userinput); //makes mynumber into a int so it can be used as output again cause else the type doesnt fit
// mynumber=int.parse(console.readline());
//Console.WriteLine("you entered: " + mynumber);
//onsole.ReadKey();

// addition calculator needed: 2 numbers, adding 2 numbers together, printing out the process, final result

Console.WriteLine("please enter a number");

string numberone = Console.ReadLine();

Console.WriteLine("you entered:" + numberone);

// int.Parse(numberone); BRINGT GARNICHTS GROßE LÜGE



Console.WriteLine("please enter another number");

string numbertwo = Console.ReadLine();

Console.WriteLine("you entered:" + numbertwo);

//int.Parse(numbertwo); BRINGT GARNICHTS GROßE LÜGE



/*int*/ /*double*/ float numberthree; //if you use string instead of int the final result is in case of 3+4=34 and not 7 lol

numberthree =  float.Parse(numberone) + float.Parse(numbertwo); /*double.Parse(numberone) + double.Parse(numbertwo);*/  /* int.Parse(numberone) + int.Parse(numbertwo);*/
 
//Console.WriteLine(numberone + "+" + numbertwo + "=" + numberthree);
Console.WriteLine($"{numberone} added to {numbertwo} is {numberthree}");

Console.ReadKey();














