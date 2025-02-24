using System;        // For Console
using System.IO;     // For File saving


namespace _22._02._25;

delegate void SaySomething(); // No "word" now—just "Go!"

class Program
{

    static void Main(string[] args)
    {


        // Make a helper and point to jobs
        SaySomething myHelper = SayLoud;
        myHelper += SaveItToTxtFile;

        // Just say "Go!"—no text needed
        myHelper(); // Activates both

        // Swap team
        myHelper -= SayLoud;
        myHelper -= SaveItToTxtFile;
        myHelper += MakeABackFlip;
        myHelper(); // Just flips now

        // Swap again
        myHelper -= MakeABackFlip;
        myHelper += GrokIFinallyMadeItDoYouSeeThisFunnyMethodName_ItIsAHint_hihi;
        myHelper(); // Stars time!

        myHelper -= GrokIFinallyMadeItDoYouSeeThisFunnyMethodName_ItIsAHint_hihi;



        // Set up the teacher
        RecessAnnouncer teacher = new RecessAnnouncer();

        // Friends listen to the megaphone
        teacher.RecessStarted += CheerForRecess; // Friend 1 listens
        teacher.RecessStarted += RunOutside;     // Friend 2 listens
        teacher.RecessStarted += GrokIFinallyMadeItDoYouSeeThisFunnyMethodName_ItIsAHint_hihi;
        teacher.RecessStarted += SayLoud;
        teacher.RecessStarted += MakeABackFlip;

        // Teacher yells "Recess!"
        teacher.StartRecess();

        // Wait and finish
        Console.ReadKey();
    }

    static void SayLoud()
    {
        Console.WriteLine("Leoni!"); // Hardcoded text

        File.AppendAllText("/Users/leoni/Documents/projects/c# projects/22.02.25/file.txt", 
            "Grok saved: Leoni!\n");
    }

    static void SaveItToTxtFile()
    {
        File.AppendAllText("/Users/leoni/Documents/projects/c# projects/22.02.25/file.txt", 
            "Grok saved: Grok is helping me\n");
    }

    static void MakeABackFlip()
    {
        Console.WriteLine("Lets flip: 🤸🤸‍♀️🤸‍♂️");
        File.AppendAllText("/Users/leoni/Documents/projects/c# projects/22.02.25/file.txt", 
            "Grok saved: Lets flip: 🤸🤸‍♀️🤸‍♂️\n");
    }

    static void GrokIFinallyMadeItDoYouSeeThisFunnyMethodName_ItIsAHint_hihi()
    {
        string catchthestars = "🌌🌌🌌🌌🌌\n✨✨✨✨✨✨✨✨\n✩₊˚.⋆☾⋆⁺₊✧\n*ੈ✩‧₊˚";
        Console.WriteLine(catchthestars);
        File.AppendAllText("/Users/leoni/Documents/projects/c# projects/22.02.25/file.txt", 
            $"Grok saved: Per astera ad Astra\n{catchthestars}\n");
    }

    // Friend 1 cheers
    static void CheerForRecess()
    {
        Console.WriteLine("Student 1: Yay, recess!");
    }

    // Friend 2 runs
    static void RunOutside()
    {
        Console.WriteLine("Student 2: Running outside!");
    }

    class RecessAnnouncer
    {
    
        public event SaySomething RecessStarted; // The megaphone!

        public void StartRecess()
        {
            Console.WriteLine("Teacher says: Recess time!");
            RecessStarted();  // Shout through the megaphone  //Grok is the ?.Invoke here really neccesary? it seems stupid. --yep fixed
        }
    }
}