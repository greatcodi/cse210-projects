public class Address
{
    private string streetName, city, state, country;
    private int houseNumber, ZIPCode;
    public Address(string _streetName, string _city, string _state, string _country, int _houseNumber, int _ZIPCode)
    {
        streetName = _streetName;
        city = _city;
        state = _state;
        country = _country;
        houseNumber = _houseNumber;
        ZIPCode = _ZIPCode;
    }
    public string GetFullAddress()
    {
        return $"{houseNumber} {streetName} St. {city}, {state}, {country} {ZIPCode}";
    }
}