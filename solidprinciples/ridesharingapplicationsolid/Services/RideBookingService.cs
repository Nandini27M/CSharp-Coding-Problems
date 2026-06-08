using System;

public class RideBookingService
{
    private readonly INotificationService _notificationService;

    public RideBookingService(INotificationService notificationService)
    {
        _notificationService = notificationService;
    }

    public void BookRide()
    {
        Console.WriteLine("Ride Booked Successfully");
        _notificationService.Send("Your ride has been confirmed");
    }
}