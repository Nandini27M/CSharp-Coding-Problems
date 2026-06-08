using System;

class Program
{
    static void Main()
    {
        Ride luxuryRide = new LuxuryRide();

        Console.WriteLine(
            $"Luxury Ride Fare: {luxuryRide.CalculateFare(10)}");

        Ride bikeRide = new BikeRide();

        Console.WriteLine(
            $"Bike Ride Fare: {bikeRide.CalculateFare(10)}");

        Ride autoRide = new AutoRide();

        Console.WriteLine(
            $"Auto Ride Fare: {autoRide.CalculateFare(10)}");

        INotificationService notification =
            new WhatsAppNotification();

        RideBookingService bookingService =
            new RideBookingService(notification);

        bookingService.BookRide();
    }
}