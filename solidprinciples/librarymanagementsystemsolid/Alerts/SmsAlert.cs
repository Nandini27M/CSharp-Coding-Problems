using System;

public class SmsAlert : IAlertService
{
    public void SendAlert(string message)
    {
        Console.WriteLine($"SMS Alert: {message}");
    }
}