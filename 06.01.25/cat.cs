namespace Cats;

class Cat
{

private static int nextID = 0;

private readonly int _id;

private string _furColour = "";

public static int NumberofCats = 0;

private string _password;


//write only property
public string Password {set{ _password = value;}}


public Cat(string furColour)
    {
    Console.WriteLine($"its a cat in {furColour}.");
    _furColour = furColour;
    NumberofCats++;
    _id = nextID++;
    }

public void RollinAround()
    {
    Console.WriteLine("This cat is rollin around");
    }

public void readDetails()
    {
     Console.WriteLine($"details about the cat: \ncolour is: {_furColour} \nID is {_id}");   
    }





}