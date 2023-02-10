public class Reception : Event
{   
    private string email;
    
    public Reception(string _eventType, string _evenTitle, string _description, string _date, string _time, Address _address, string _email) : base(_eventType, _evenTitle, _description, _date, _time, _address)
    {
        email = _email;
    }
    public string GetEmail()
    {
        return $"E-mail for RSVP: {email}";
    }
}