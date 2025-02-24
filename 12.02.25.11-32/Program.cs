namespace _12._02._25._11_32;

public interface IPaymentProcessor
{
    void ProcessPayment(decimal amount);

}

public class CreditCardProcessor : IPaymentProcessor
{
    public void ProcessPayment(decimal amount)
    {
        Console.WriteLine($"Processing the credt  card payment of the amount {amount}");
        //incrementing payment card logic
    }
}

public class PaypalProcessor : IPaymentProcessor
{
    public void ProcessPayment(decimal amount)
    {
        Console.WriteLine($"Processing the credt  paypal of the amount {amount}");
        //incrementing paypal logic
    }
}

public class PaymentService
{

    IPaymentProcessor _processor;


    public PaymentService(IPaymentProcessor processor)
    {
        _processor = processor;
    }

    public void ProcessOrderPayment(decimal amount)
    {
       _processor.ProcessPayment(amount);
    }
}

class Program
{
    static void Main(string[] args)
    {
         IPaymentProcessor CreditCardProcessor = new CreditCardProcessor();
         PaymentService paymentService = new PaymentService(CreditCardProcessor);
         paymentService.ProcessOrderPayment(100.00m);

         IPaymentProcessor PaypalProcessor = new PaypalProcessor();
         PaymentService paymentService2 = new PaymentService(PaypalProcessor);
         paymentService2.ProcessOrderPayment(400.00m);


        Console.WriteLine("Hello, World!");
       
    }
}
