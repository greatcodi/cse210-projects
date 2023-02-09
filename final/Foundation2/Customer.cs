
public class Customer
{
    private string _name;
    private Address _address;
    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }
    public bool LiveUSA()
    {
        string country = _address.WhatCountry();
        country = country.ToUpper();
        if (country != "USA")
        {
            return false;
        }else{
            return true;
        }
        
    }
    public string GetCustomerName()
    {
        return _name;
    }
    public Address GetAddress()
    {
        return _address;
    }

}