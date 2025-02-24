namespace _15._02._25._11_31;

public interface IPrintable
{
    void Print();
}

public interface IScannable
{
    void Scan();
}

public class MultiFunctionPrinter : IPrintable, IScannable
{
public void Print()
{
Console.WriteLine("Printing Document");
}

public void Scan()
{
Console.WriteLine("Scanning Document");
}


}



class Program
{
    static void Main(string[] args)
    {
        MultiFunctionPrinter Drucker = new MultiFunctionPrinter();
        Drucker.Scan();
        Drucker.Print();
        Console.WriteLine("Hello, World!");
    }
}
