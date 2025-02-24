using System;        // For Console
using System.IO;     // For File saving

namespace _21._02._25._14_43;


delegate void SaySomething(string word); // The helper rule: takes a word, says something

class Program
{
    static void Main(string[] args)
    {
        // Make a helper and point it to a job
        SaySomething myHelper = SayLoud;
        myHelper += SaveItToTxtFile; // Add the save-to-file job
       




        // Two ways to tell the helper "Go!"
        // Two ways to tell the helper "Go!"
        myHelper("Leoni");         // Way 1: Direct call (says loud + saves)
        myHelper.Invoke("Grok is helping me"); // Way 2: Using Invoke (says loud + saves)
        

        myHelper -= SayLoud;
        myHelper -= SaveItToTxtFile;

        myHelper += MakeABackFlip;  // Add the backflip job *before* calling
        myHelper.Invoke("🤸🤸‍♀️🤸‍♂️"); 
        myHelper -= MakeABackFlip;


       
        myHelper += GrokIFinallyMadeItDoYouSeeThisFunnyMethodName_ItIsAHint_hihi;
        myHelper.Invoke("Grok, is this Message part really neccesary, i can simply put every neccesary text in the Method and not overcomplicate it, what other things could be added here exept text? \n");
        



       
        
        
        

        // Wait and finish
        Console.ReadKey();
    }

    static void SayLoud(string word)
    {
        Console.WriteLine($"{word}!");
    }

    static void SaveItToTxtFile(string word) // Fixed to match delegate
    {
        File.AppendAllText("/Users/leoni/Documents/projects/c# projects/21.02.25.14-43/info.txt", 
            $"Grok saved: {word}\n");
    }

    static void MakeABackFlip(string flip)
    {
        Console.WriteLine($"Lets flip: {flip}");
        File.AppendAllText("/Users/leoni/Documents/projects/c# projects/21.02.25.14-43/info.txt", 
            $"Grok saved:  Lets flip: {flip} \n");

    }

    static void GrokIFinallyMadeItDoYouSeeThisFunnyMethodName_ItIsAHint_hihi(string catchthestars)
    {
        
        catchthestars =
         "🌌🌌🌌🌌🌌 \n ✨✨✨✨✨✨✨✨\n✩₊˚.⋆☾⋆⁺₊✧\n*ੈ✩‧₊˚  ";
        File.AppendAllText("/Users/leoni/Documents/projects/c# projects/21.02.25.14-43/info.txt", 
            $"Grok saved: Per astera ad Astra(this is a hint as well, if you read this teach me some similar smart latin sentences:) \n {catchthestars} \n");

        Console.WriteLine(catchthestars);
    }
}