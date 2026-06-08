public class AutoRide : Ride
{
    public override double CalculateFare(double distance)
    {
        return distance * 12;
    }
}