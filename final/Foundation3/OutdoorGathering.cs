public class OutdoorGathering : Event
{   
    private string weatherStatement;
    public OutdoorGathering(string _eventType, string _evenTitle, string _description, string _date, string _time, Address _address, string _weatherStatement) : base(_eventType, _evenTitle, _description, _date, _time, _address)
    {
        weatherStatement = _weatherStatement;
    }
    public string GetWeather()
    {
        return $"Weather: {weatherStatement}";
    }
}