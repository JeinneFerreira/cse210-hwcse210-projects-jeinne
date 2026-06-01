public class Address
{
// =====================================================
// --------------- Private attributes ------------------ 
// =====================================================

    private string _street;

    private string _city;

    private string _state;

    private string _country;

// =====================================================
// ------------------- Constructor --------------------- 
// =====================================================


    public Address(
        string street,
        string city,
        string state,
        string country)
    {
        _street = street;

        _city = city;

        _state = state;

        _country = country;
    }

// =====================================================
// --------------- Function: Check if USA -------------- 
// =====================================================

    public bool IsInUSA()
    {
        return _country.ToUpper() == "USA";
    }

// =====================================================
// ----------- Function: Return full address ----------- 
// =====================================================

    public string GetFullAddress()
    {
        return
            $"{_street}\n" +
            $"{_city}, {_state}\n" +
            $"{_country}";
    }
}