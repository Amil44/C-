using System;
using System.Net;
using System.Net.Mail;

class Program
{
    static void Main()
    {
        string emailsender = "youremail@gmail.com";
        string appPassword = Environment.GetEnvironmentVariable("GMAIL_APP_PASSWORD");

        if (string.IsNullOrEmpty(appPassword))
        {
            Console.WriteLine("Value hasnt set yet");
            return;
        }

        MailMessage mail = new MailMessage();
        mail.From = new MailAddress(emailsender);
        mail.To.Clear();
        mail.To.Add(emailsender);
        mail.Subject = "Email from myself";
        mail.Body = "Sending my first mail in C#";

        using SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
        smtp.EnableSsl = true;
        smtp.UseDefaultCredentials = false;
        smtp.Credentials = new NetworkCredential(emailsender, appPassword);

        try
        {
            Console.WriteLine(mail.To[0].Address);
            Console.WriteLine(mail.To[0].DisplayName);
            smtp.Send(mail);
            Console.WriteLine("Succesfully sent");
        }
        catch (SmtpException msg)
        {
            Console.WriteLine(msg.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error occured: {ex.Message}");
        }
    }
}