namespace _18._02._25._10_41;

// Renamed delegate to be more descriptive: it handles logging messages
public delegate void MessageLogger(string message);

public class Logger
{
    // Method to log a message to the console
    public void LogToConsole(string message)
    {
        Console.WriteLine($"Console Log: {message}");
    }

    // Method to log a message to a file (simulated here by printing to console)
    public void LogToFile(string message)
    {
        Console.WriteLine($"File Log: {message}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create an instance of the Logger class to handle logging
        Logger logger = new Logger();

        // Create a delegate instance (messageLogger) initially pointing to LogToConsole
        // This is like setting up a function call that can be changed later
        MessageLogger messageLogger = logger.LogToConsole;

        // Add another logging method (LogToFile) to the delegate to make it multicast
        // Now messageLogger will call both LogToConsole and LogToFile when invoked
        messageLogger += logger.LogToFile;

        // Invoke the delegate, which now calls both logging methods with this message
        messageLogger("log this info!");

        // Loop through all methods in the delegate's invocation list
        // This shows how many logging methods are set up
        foreach (MessageLogger handler in messageLogger.GetInvocationList())
        {
            try
            {
                // Try to call each logging method with this message
                handler("Event occurred with error handling");
            }
            catch (Exception ex)
            {
                // If something goes wrong (e.g., a method throws an exception), print the error
                Console.WriteLine($"Exception caught: {ex.Message}");
                throw; // Re-throw the exception to ensure it’s handled further up if needed
            }
        }

        // Check if LogToFile is part of the delegate's invocation list
        if (IsMethodInDelegate(messageLogger, logger.LogToFile))
        {
            // If it is, remove LogToFile from the delegate
            messageLogger -= logger.LogToFile;
            Console.WriteLine("LogToFile Method removed");
        }
        else
        {
            // If it’s not found, let the user know
            Console.WriteLine("LogToFile Method not found!");
        }


        // Safely invoke the delegate after possible removal, ensuring it won't crash if empty
        InvokeSafely(messageLogger, "After removing LogToFile, this is a message and I don't know how it appeared here");

        // Wait for user input before closing the console
        Console.ReadKey();

        // Print a greeting (this line can be moved earlier if you want it at the start)
        Console.WriteLine("Hello, World!");
    }

    // Helper method to safely invoke a delegate, avoiding null reference exceptions
    static void InvokeSafely(MessageLogger loggerDelegate, string message)
    {
        // Create a temporary copy to avoid race conditions if the delegate changes
        MessageLogger temporaryLogger = loggerDelegate;

        // Only invoke if the delegate is not null (has at least one method)
        if (temporaryLogger != null)
        {
            temporaryLogger(message);
        }
    }

    // Helper method to check if a specific method is part of a delegate's invocation list
    static bool IsMethodInDelegate(MessageLogger loggerDelegate, MessageLogger methodToCheck)
    {
        // Return false if the delegate is null (no methods to check)
        if (loggerDelegate == null)
        {
            return false;
        }

        // Loop through each method in the delegate's invocation list
        foreach (Delegate d in loggerDelegate.GetInvocationList())
        {
            // Compare each method in the list with the method we're looking for
            if (d == (Delegate)methodToCheck)
            {
                return true; // Found a match
            }
        }

        // If no match is found after checking all methods
        return false;
    }
} 