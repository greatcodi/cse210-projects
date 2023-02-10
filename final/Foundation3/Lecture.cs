public class Lecture : Event
{
    private string speakerName;
    private int capacity;
    public Lecture(string _eventType, string _evenTitle, string _description, string _date, string _time, Address _address, string _speakerName, int _capacity) : base(_eventType, _evenTitle, _description, _date, _time, _address)
    {
        speakerName = _speakerName;
        capacity = _capacity;
    }
    public string GetFullDetails()
    {
        return $"Speaker: {speakerName}\n\rCapacity: {capacity}";
    }
}