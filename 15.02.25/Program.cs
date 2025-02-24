namespace _15._02._25;

class Program
{
    static void Main(string[] args)
    {
        var loggingService = new LoggingService();

        var constructorInjection = new MyClassConstructorInjection(loggingService);
        constructorInjection.PerformAction(); // Call PerformAction on constructorInjection

        var setterInjection = new MyClassSetterInjection { LoggingService = loggingService };
        setterInjection.PerformAction(); // Call PerformAction on setterInjection

        var interfaceInjection = new MyClassInterfaceInjection();
        interfaceInjection.SetDependency(loggingService);
        interfaceInjection.PerformAction(); // Call PerformAction on interfaceInjection

        Console.WriteLine("Hello, World!");
    }
}

public interface ILoggingService
{
    void Log(string message);
}

public class LoggingService : ILoggingService
{
    public void Log(string message)
    {
        Console.WriteLine(message);
    }
}

public class MyClassConstructorInjection
{
    private readonly ILoggingService _loggingService;
    public MyClassConstructorInjection(ILoggingService loggingService)
    {
        _loggingService = loggingService;
    }

    public void PerformAction()
    {
        _loggingService.Log("Constructor Injection: Logging message.");
    }
}

public class MyClassSetterInjection
{
    public ILoggingService LoggingService { private get; set; }

    public void PerformAction()
    {
        LoggingService.Log("Setter Injection: Logging message.");
    }
}

public interface IDependencyInjector
{
    void SetDependency(ILoggingService loggingService);
}

public class MyClassInterfaceInjection : IDependencyInjector
{
    private ILoggingService _loggingService;
    public void SetDependency(ILoggingService loggingService)
    {
        _loggingService = loggingService;
    }

    public void PerformAction()
    {
        _loggingService.Log("Interface Injection: Logging message.");
    }
}
