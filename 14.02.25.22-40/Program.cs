namespace _14._02._25._22_40;

class Program
{
    static void Main(string[] args)
    {

        var loggingService = new LoggingService();

        var constructorInjection = new MyClassConstructorInjection(loggingService);
        constructorInjection.PerformAction();

        var setterInjection = new MyClassSetterInjection { LoggingService = loggingService };
        setterInjection.PerformAction();

        var interfaceInjection = new MyClassInterfaceInjection();
        interfaceInjection.SetDependency(loggingService);
        interfaceInjection.PerformAction();



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
            // TODO: Use _loggingService to log "Constructor Injection: Logging message."
            _loggingService.Log("Constructor Injection: Logging message.");
        }
    }





    public class MyClassSetterInjection
    {
        public ILoggingService LoggingService { private get; set; }

        public void PerformAction()
        {
            // TODO: Use LoggingService to log "Setter Injection: Logging message."
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
            // TODO: Use _loggingService to log "Interface Injection: Logging message."

             _loggingService.Log("Interface Injection: Logging message.");


        }
    }
