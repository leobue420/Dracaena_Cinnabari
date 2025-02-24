namespace _13._02._25._20_14;


public interface ILogger
{
    void Log(string message);

}

public class FileLogger : ILogger
{
    public void Log(string message)
    {
         string directoryPath = @"/Users/leoni/Documents/projects/c# projects/14.02.25-11-23";
        string filePath = Path.Combine(directoryPath, "trololol sneeeeens.txt");
        string Message = "This is a log entry";

        File.AppendAllText(filePath, "Hello World " + Message + "\n");

        if(Directory.Exists(directoryPath))
        {
            Directory.CreateDirectory(directoryPath);
        }




        Console.ReadKey();

    }
}

public class DatabaseLogger : ILogger
{
    public void Log(string message)
    {
        Console.WriteLine($"Logging to database. {message}");
    }
}

public class Application
{
    private readonly ILogger _logger;

    public Application(ILogger logger)
    {
        _logger = logger;
    }

    public void DoWork()
    {
        _logger.Log("Work started");
        _logger.Log("Work done");
    }
}

class Program
{


    static void Main(string[] args)
    {
        ILogger FileLogger = new FileLogger();
        Application App = new Application(FileLogger);
        App.DoWork();

       ILogger dbLogger =new DatabaseLogger();
       App = new Application (dbLogger);
       App.DoWork();



        Console.WriteLine("Hello, World!");
    }
}
