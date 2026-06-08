using System;

public class CreditCardPayment : IPaymentService
{
    public void Pay(decimal amount)
    {
        Console.WriteLine($"Payment of {amount} completed using Credit Card.");
    }
}