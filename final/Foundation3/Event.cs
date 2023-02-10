public class Event
{
    private string  eventTitle, description, date, time, eventType;
    private Address address;
    public Event(string _eventType, string _evenTitle, string _description, string _date, string _time, Address _address)
    {
        eventTitle = _evenTitle;
        description = _description;
        date = _date;
        time = _time;
        address = _address;
        eventType = _eventType;
        
    }


    public string StandarDetails()
    {
        return $"Title: {eventTitle}\n\rDescription: {description}\n\rTime: {date} - {time}\n\rAddress: {address.GetFullAddress()}";
    }
    public string ShortDescription()
    {
        return $"Type of Evernt: {eventType}\n\rTittle: {eventTitle}\n\rDate: {date}";
    }
    
}