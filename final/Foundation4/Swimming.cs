public class Swimming : Activity
{
    private int laps;
    public Swimming(string _activityType, string _date, int _lenghtMinutes, double _distance,  int _laps) : base(_activityType, _date, _lenghtMinutes, _distance)
    {
        laps = _laps;
    }
    public double CalculateDistance()
    {
        return (laps * 50) / 1000;
    }
    public override string GetSummary()
    {
        return $"°{GetDate()} ({GetMinutes()})-Distance {CalculateDistance()} km, Speed: {CalculateSpeed()} kph, Pace: {CalculatePace()} min per km";
    }
}