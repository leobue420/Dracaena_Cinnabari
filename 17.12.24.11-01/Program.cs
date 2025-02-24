// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


// for (int i = 0; i < length; i++)
// {
//     Console.WriteLine(i);
// }
// WHILE LOOP
// int counter = 0;
// while (counter < 10)
// {
//    Console.WriteLine(counter);
//    counter++; 
// }

// bool isgood = true;

// while(isgood)
// {
//     Console.WriteLine(isgood);
//     isgood = false;
// }

// Console.ReadLine();


//WHILE PRACTICE 1
// Console.WriteLine("enter go or stay");

// string userchoice = "go";
// while(userchoice == "go")
// {
// Console.WriteLine("life is good, go on (enter go or stay)");
// userchoice = Console.ReadLine();
// }

// Console.WriteLine("finally you stay!");

//WHILE PRACTICE 2

Console.WriteLine("choose a number between 1 and 100");

Random random = new Random();

int secretnumber = random.Next(1 , 101);
int userguess = 0;
int counter = 0;

while (userguess != secretnumber)
{
    Console.WriteLine("please enter a number: ");
    userguess = Convert.ToInt32(Console.ReadLine());
    counter++;
    if(userguess < secretnumber)
    Console.WriteLine("try again with a higher number");
    else if(userguess > secretnumber)
    Console.WriteLine("try with a lower number");

}
Console.WriteLine($"you guessed correctly it took you {counter} tries");
Console.ReadLine();

