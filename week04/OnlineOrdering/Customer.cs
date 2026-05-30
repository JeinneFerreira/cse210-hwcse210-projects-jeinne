public class Customer
{
// =====================================================
// ---------------- Private attributes ----------------- 
// =====================================================

    private string _name;

    private Address _address;

// =====================================================
//  ---------------- Constructor ----------------------
// =====================================================

    public Customer(
        string name,
        Address address)
    {
        _name = name;

        _address = address;
    }

// =====================================================
//  ---- Function: Check if customer lives in USA ------
// =====================================================

    public bool LivesInUSA()
    {
        return _address.IsInUSA();
    }

// =====================================================
//  ---------------------- Getters ---------------------
// =====================================================

    public string GetName()
    {
        return _name;
    }

    public Address GetAddress()
    {
        return _address;
    }
}