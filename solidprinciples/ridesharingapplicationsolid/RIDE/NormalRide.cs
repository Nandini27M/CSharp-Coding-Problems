public class NormalRide : Ride
{
    public override double CalculateFare(double distance)
    {
        return distance * 10;
    }
}