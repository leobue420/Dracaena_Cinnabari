namespace _26._02._25;

using System;
using System.Net.Mail;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Enter the message you want to send via email:");
            string message = Console.ReadLine();

            if (!string.IsNullOrEmpty(message))
            {
                using (MailMessage mail = new MailMessage())
                {
                    mail.From = new MailAddress("leoni.buettner@web.de"); // Your Web.de email
                    mail.To.Add("leobue@t-online.de"); // Recipient's T-Online email (or add more recipients like your family!)
                    mail.Subject = "Console Email Test";
                    mail.Body = message;


                       // Custom SMTP client to log communication (limited by System.Net.Mail)
                    SmtpClient smtpClient = new SmtpClient("smtp.web.de")
                    {
                        Port = 587, // Try 587 first (TLS), or 465 (SSL) if it fails
                        Credentials = new System.Net.NetworkCredential("leoni.buettner@web.de", "password"), // Replace with your Web.de password or app-specific password
                        EnableSsl = true, // Use TLS for secure connection
                        //Timeout = 300000 // Increase timeout to 300 seconds (5 minutes)
                    };

                    // Simulate logging by overriding Send (very basic, not full protocol capture)
                    smtpClient.SendCompleted += (sender, e) =>
                    {
                        if (e.Error != null)
                        {
                            Console.WriteLine($"SMTP Error: {e.Error.Message}");
                        }
                        else
                        {
                            Console.WriteLine("SMTP Communication (simulated): Connection established, authentication sent, email delivered.");
                        }
                    };

                    smtpClient.Send(mail);
                    Console.WriteLine("Email sent successfully!");
                }
            }
            else
            {
                Console.WriteLine("No message entered. Please try again.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Failed to send email: {ex.Message}");
        }
    }
}