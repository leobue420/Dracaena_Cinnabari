using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MyQuizApp;

public class Quiz
{
Question[] questions;

public Quiz(Question[] questions)
{
    this.questions = questions;
    score = 0;
}

private void DisplayQuestion(Question question)
{

    Console.ForegroundColor = ConsoleColor.DarkYellow;
     Console.WriteLine("╔═════════════════════════════════════════════════════════════════════════╗");
     Console.WriteLine("║                                 Question                                ║");
     Console.WriteLine("╚═════════════════════════════════════════════════════════════════════════╝");
     Console.ResetColor();


    Console.WriteLine(question.QuestionText);

    for (int i = 0; i < question.Answers.Length; i++)
    {
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.Write("   ");
        Console.Write(i+1);
        Console.ResetColor();
     

        Console.WriteLine($"{question.Answers[i]}");
    }

    // if(getUserChoice() == question.CorrectAnswerIndex)
    //     {
    //         Console.WriteLine("correct");
    //     }
    //     else
    //     {
    //         Console.WriteLine("Incorrect");
    //     }

}

public int getUserChoice()
{
    Console.Write("Your answer (number):");
    string input = Console.ReadLine();
    int choice = 0;
    while(!int.TryParse(input, out choice)|| choice < 1 || choice > 4)
    {
        Console.WriteLine("Invalid choice, please enter a number between 1 and 4");
        input = Console.ReadLine();
    }
    return choice-1;

}



public void StartQuiz()
{
Console.WriteLine("Welcome to the Quiz");
int questionNumber = 1; //to display question numbers

foreach (Question question in questions)
{
    Console.WriteLine($"Question {questionNumber++}");
    DisplayQuestion(question);
    int Userchoice = getUserChoice();
    if (question.IsCorrectAnswer(Userchoice))
    {
        Console.WriteLine("Correct!");
        score++;
    }
    else
    {Console.WriteLine($"wrong, the right answer is{question.Answers[question.CorrectAnswerIndex]}");}
}

DisplayResults();
}

private int score;

private void DisplayResults()
{
     Console.ForegroundColor = ConsoleColor.DarkMagenta;
     Console.WriteLine("╔═════════════════════════════════════════════════════════════════════════╗");
     Console.WriteLine("║                                 Results (yay)                               ║");
     Console.WriteLine("╚═════════════════════════════════════════════════════════════════════════╝");
     Console.ResetColor();
     Console.WriteLine($"Quiz finished ypu score is {score} out of {questions.Length}");

    double percentage = (double)score/questions.Length;
    if (percentage >= 0.8)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Excellent Work");
    }
    else if(percentage >= 0.5)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("good effort ");
    }
    else
    {
            Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Get better, keep practicing");
    }
    Console.ResetColor();

    
}



}