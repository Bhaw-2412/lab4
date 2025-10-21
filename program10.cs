using System;

class Program
{
    public delegate void Notifier(string message);

    
    public static void SendEmail(string message)
    {
        Console.WriteLine($"📧 Email sent: {message}");
    }

    public static void SendSMS(string message)
    {
        Console.WriteLine($"📱 SMS sent: {message}");
    }

    static void Main()
    {
        string msg = "Assignment Submitted Successfully";

        
        Notifier notify = SendEmail;
        notify += SendSMS;  // Delegate chaining

        
        notify(msg);

        Console.WriteLine("\nAll notifications sent successfully.");
    }
}
