public class BikeRide : Ride
{
    public override double CalculateFare(double distance)
    {
        return distance * 8;
    }
}