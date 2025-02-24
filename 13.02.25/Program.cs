namespace _13._02._25;
public interface IPayment
{
    void ProcessPayment();

}

public class CreditCardPayment : IPayment
{
    public void ProcessPayment()
    {
        Console.WriteLine($"Processing the credt  card payment");
        //incrementing payment card logic
    }
}

public class PayPalPayment : IPayment
{
    public void ProcessPayment()
    {
        Console.WriteLine($"Processing the credt  paypal ");
        //incrementing paypal logic
    }
}

// public class PaymentService
// {

//    IPayment _processor;


//     public PaymentService(IPayment processor)
//     {
//         _processor = processor;
//     }

//     public void ProcessOrderPayment(decimal amount)
//     {
//        _processor.ProcessPayment(amount);
//     }
// }

class Program
{
    static void Main(string[] args)
    {
         IPayment CreditCardProcessor = new CreditCardPayment();
        //  PaymentService paymentService = new PaymentService(CreditCardProcessor);
         CreditCardProcessor.ProcessPayment();

         IPayment PaypalProcessor = new PayPalPayment();
        //  PaymentService paymentService2 = new PaymentService(PaypalProcessor);
         PaypalProcessor.ProcessPayment();


        Console.WriteLine("Hello, World!");
       
    }
}

