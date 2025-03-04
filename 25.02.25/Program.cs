using System.Net.Mail; // Ensure this line is present and correct


namespace _25._02._25;

//public delegate void TemperatureChangeHandler(string message);



public class TemperatureChangedEventArgs : EventArgs
{

    //property holding the temperature
    public int Temperature {get;}


//constructor
    public TemperatureChangedEventArgs(int temperature)
    {
        Temperature = temperature;
    }
}

public class TemperatureMonitor
{

    public event EventHandler<TemperatureChangedEventArgs> TemperatureChanged;

    //public event TemperatureChangeHandler? OnTemperatureChanged = null;

    private int _temperature;

    private int _maxTemperature;
    public int  Temperature
    {
    get{return _temperature;}
    
    set
    {
        _temperature = value;

        if (value < -100 || value > 100)
            throw new ArgumentException("Temperature must be between -100 and 100!");
           
        _temperature = value; // Assign the new value to the field

        // if (_temperature > 30) // Check the stored field, not value
        //     {
        //         RaiseTemperatureChangedEvent("Temperature is above threshold- Liebe Grüße von Leoni, die Mail ist selbst programmiert.");
        //     }

        //     if (_temperature > _maxTemperature) // Update max with the stored field
        //     {
        //         _maxTemperature = _temperature;
        //     }
          //old version

        int oldTemperature = _temperature; // Store the current temperature
_temperature = value; // Set the new temperature

if (oldTemperature != value) // Check if the temperature actually changed
{
    RaiseTemperatureChangedEvent(new TemperatureChangedEventArgs(value));
}
    }
}

    public int MaxTemperature
    {
        get { return _maxTemperature; } // Read-only property
    }

   protected virtual void RaiseTemperatureChangedEvent(TemperatureChangedEventArgs temperatureChangeInfo)
{
    TemperatureChanged?.Invoke(this, temperatureChangeInfo);


        // Send email alert (example – configure SMTP settings)
        try
        {
            using (MailMessage mail = new MailMessage())
            {
                mail.From = new MailAddress("leoni.buettner@web.de"); // Your Web.de email
                    mail.To.Add("leobue@t-online.de"); // Recipient's T-Online email
                    mail.Subject = "Temperature Alert";
                   mail.Body = $"Alert: Temperature is {temperatureChangeInfo.Temperature}°C. Liebe Grüße von Leoni, die Mail ist selbst programmiert."; // Use temperature from event args

                    SmtpClient smtpClient = new SmtpClient("smtp.web.de") // Web.de SMTP server
                    {
                        Port = 587, // TLS port for Web.de
                        Credentials = new System.Net.NetworkCredential("leoni.buettner@web.de", "fyzkax-fEzto5-zywhek"), // Replace with your Web.de password or app-specific password
                        EnableSsl = true // Use TLS for secure connection
                    };

                    smtpClient.Send(mail);
                    Console.WriteLine("Email sent successfully!");
                }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Failed to send email: {ex.Message}");
        }

        
    }
}

//subscriber

public class TemperatureAlert
{
    public void OnTemperatureChanged(object sender, TemperatureChangedEventArgs e)
    {
        Console.WriteLine($"Alert: Temperature is {e.Temperature} and the Sender is {sender}");
    }
}

public class TemperatureColdAlert
{
    public void OnTemperatureChanged(object sender, TemperatureChangedEventArgs e)
    {
        Console.WriteLine($"Alert: Temperature is {e.Temperature} and the Sender is {sender}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        TemperatureMonitor monitor = new TemperatureMonitor();
        TemperatureAlert alert = new TemperatureAlert();
        TemperatureColdAlert alert2 = new TemperatureColdAlert();




        monitor.TemperatureChanged += alert.OnTemperatureChanged;
       // monitor.OnTemperatureChanged += alert.OnTemperatureChanged; -Old Version
       monitor.TemperatureChanged += alert2.OnTemperatureChanged;

        monitor.Temperature =20;


        Console.WriteLine("Please enter a temperature");
        monitor.Temperature = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Hello, World!");
    }
}
