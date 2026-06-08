public class LuxuryRide : Ride
{
    public override double CalculateFare(double distance)
    {
        return distance * 25;
    }
}