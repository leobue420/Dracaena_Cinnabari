// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, Quiz!");

string question1 = ("What is the capital of Germany?");
string answer1 = ("Berlin");

string question2 = ("What is 2+2?");
string answer2 = ("4");

string question3 = ("What colour do you get by mixing blue and yellow?");
string answer3 = ("green");

int score = 0;

Console.WriteLine(question1);
string userAnswer1 = Console.ReadLine();
if (userAnswer1.Trim().ToLower() == answer1.ToLower())
{
Console.WriteLine("correct!");
score = score+1;
Console.WriteLine($"your score is {score}");
}
else
{
Console.WriteLine($"Wrong, the correct answer is {answer1}");
}

Console.WriteLine(question2);
string userAnswer2 = Console.ReadLine();
if (userAnswer2.Trim().ToLower() == answer2.ToLower())
{
Console.WriteLine("correct!");
score = score+1;
Console.WriteLine($"your score is {score}");
}
else
{
Console.WriteLine($"Wrong, the correct answer is {answer2}");
}


Console.WriteLine(question3);
string userAnswer3 = Console.ReadLine();
if (userAnswer3.Trim().ToLower() == answer3.ToLower())
{
Console.WriteLine("correct!");
score = score+1;
Console.WriteLine($"your score is {score}");
}
else
{
Console.WriteLine($"Wrong, the correct answer is {answer3}");
}


Console.WriteLine($"quiz completed, your score is {score}/3");
if(score == 3)
{
Console.WriteLine("you got all answers right");
}
else if(score == 2)
Console.WriteLine($"there is a chance that you are stupid but you could very well just have made a typo");
else if (score == 1)
Console.WriteLine("you might be stupid");
else
Console.WriteLine("okay, thats a bad result");
Console.ReadKey();
