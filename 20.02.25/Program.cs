namespace _20._02._25;

// Step 1: Make a delegate "type" - it’s like a rule saying, “This helper only does jobs that take a name and say something.”
delegate void SayHello(string name);

class Program
{
    static void Main(string[] args)
    {
        // Step 2: Make some fun "jobs" (methods) the delegate can do.
        // These are like your friends who can say hello in different ways.
        // SayHelloToClass("Leoni"); // Call it directly first, without a delegate.
        // SayHelloQuietly("Leoni");

        // Step 3: Create a delegate "helper" and tell it which job to do.
        SayHello myHelper = SayHelloQuietly; // Point to the loud hello job.
        myHelper("Leoni"); // Tell the helper to do the job with "Leoni".

        // Step 4: Swap the job! Now the helper does a quiet hello.
        myHelper = SayHelloToClass;
         myHelper("Leoni"); // Same helper, different job.

        // Step 5: Add more jobs to the helper (like having two friends at once).
        // myHelper = SayHelloToClass; // Start with loud hello.
        myHelper += SayHelloQuietly; // Add quiet hello too.
        myHelper("Leoni 2"); // Now it does BOTH jobs!

        // Step 6: Wait for you to press a key so the program doesn’t close right away.
        Console.WriteLine("Press any key to finish!");
        Console.ReadKey();
    }

    // Job 1: A loud hello to the whole class.
    static void SayHelloToClass(string name)
    {
        Console.WriteLine($"HELLO, {name}! THE WHOLE CLASS HEARS THIS!");
    }

    // Job 2: A quiet hello just to you.
    static void SayHelloQuietly(string name)
    {
        Console.WriteLine($"hi, {name}, just a little whisper...");
    }
}

