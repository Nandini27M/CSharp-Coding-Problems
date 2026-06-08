using System;

public class EmailAlert : IAlertService
{
    public void SendAlert(string message)
    {
        Console.WriteLine($"Email Alert: {message}");
    }
}