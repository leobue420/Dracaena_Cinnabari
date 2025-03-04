// We’re using special tools (libraries) to help send emails and talk to email servers!
using MailKit.Net.Smtp; // This is like a magic box for sending emails over the internet
using MimeKit; // This helps us build and shape the email, like putting a letter in an envelope
using System; // This is a basic toolbox with stuff like printing messages on the screen

// We’re making a group (namespace) for our code, named after today’s date
namespace _27._02._25;

// This is our main program, like the starting point of a game
class Program
{
    // This is where our game starts—it’s like the first page of a storybook
    static void Main(string[] args)
    {
        try // We’re putting on a safety net to catch any oopsies (errors) that might happen
        {
            // Ask the player (you) to type a message they want to send in an email
            Console.WriteLine("Enter the message you want to send via email:");
            // Read what you type and save it in a box called 'message'—it can be empty or nothing (nullable)
            string? message = Console.ReadLine(); // Made nullable so we don’t get a warning if you don’t type anything

            // Check if the message box isn’t empty or blank before we send it
            if (!string.IsNullOrEmpty(message))
            {
                // Make a new email letter (like a fancy envelope) using MimeKit
                var email = new MimeMessage();
                // Add who’s sending it: you, Leoni, with your email address
                email.From.Add(new MailboxAddress("Leoni", "leoni.buettner@web.de"));
                // Add who’s getting it: someone with their email (you can change this to leobue@t-online.de or anyone!)
                email.To.Add(new MailboxAddress("Recipient", "leobue@t-online.de"));
                // Give the email a title, like the subject line on a letter
                email.Subject = "Simple Email Test";
                // Put your message inside the email as simple text, like writing on paper
                email.Body = new TextPart("plain") { Text = message };

                // Use a magic helper (SmtpClient) to send the email, and clean up after (like closing a door)
                using (var client = new SmtpClient())
                {
                    // Skip checking the email server’s ID card for now (not safe for real use, but easier for testing)
                    client.ServerCertificateValidationCallback = (s, c, h, e) => true;
                    // Connect to Web.de’s email post office on door 587 with a secure lock (TLS)
                    client.Connect("smtp.web.de", 587, MailKit.Security.SecureSocketOptions.StartTls);

                    // Log in to Web.de using your email and secret password (replace with your real one!)
                    client.Authenticate("leoni.buettner@web.de", "Password"); // Put your Web.de password or special code here

                    // Send the email letter to the post office
                    client.Send(email);
                    // Yippee! Tell the player the email was sent
                    Console.WriteLine("Email sent successfully!");
                    // Close the connection to the post office nicely
                    client.Disconnect(true);
                }
            }
            else
            {
                // If you didn’t type anything, tell you to try again
                Console.WriteLine("No message entered. Please try again.");
            }
        }
        catch (Exception ex) // If something goes wrong, catch the oopsie and tell us
        {
            // Show what went wrong in a friendly message
            Console.WriteLine($"Failed to send email: {ex.Message}");
        }
    }
}