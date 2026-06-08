using System;

public class WhatsAppNotification : INotificationService
{
    public void Send(string message)
    {
        Console.WriteLine($"WhatsApp: {message}");
    }
}