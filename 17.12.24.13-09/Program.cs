// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome to the adventure game!");

Console.WriteLine("enter your characters name");
string playername = Console.ReadLine();
Console.WriteLine("choose your characters gender");
string gender = Console.ReadLine();



Console.WriteLine($"you find yourself {playername}, {gender} at the edge of the dark forest, do you want to enter the forest or camp outside? (enter/camp)");

string choice1 = Console.ReadLine() ;
if(choice1.ToLower() == "enter")
{
Console.WriteLine("you bravely entered the forest");
}
else
{
    Console.WriteLine("you stay out of trouble and camp outside the forest");
    
}

bool gamecontinues = true;
while(gamecontinues)
{
    Console.WriteLine("you come to a fork in the road, go left or right?"); 
    string direction = Console.ReadLine();
    if(direction.ToLower() == "left")
    {
    Console.WriteLine("you find a treasure chest");
    gamecontinues = false; 
    }
    else
    {
    Console.WriteLine("you encounter a wild beast, (enter) fight or flee?");
    string fightorflee = Console.ReadLine();
        if(fightorflee.ToLower() == "fight")
        {
            Random random = new Random();
            int luck = random.Next(1, 11);
                if(luck >= 5);
                {Console.WriteLine("you beat the beast");}
                    if(luck > 8)
                    {Console.WriteLine("you got a treasure");}
                else if(luck<5)
                {Console.WriteLine("you lost");
                gamecontinues = false; }

                    

        }

    }

}
Console.WriteLine("Game Over, thank you for playing the game");