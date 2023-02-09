public class Address
{
    private string street, city, state, country;

    public Address(string _street, string _city, string _state, string _country)
    {
        street = _street;
        city = _city;
        state = _state;
        country = _country;
    }
    public string WhatCountry()
    {
        return country;
    }

    public string FullAddress()
    {
        return $"{street} St. {city}, {state} - {country}";
    }
}