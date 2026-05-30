using System.Collections.Generic;

public class Order
{
// =====================================================
// ---------------- Private attributes -----------------
// =====================================================

    private List<Product> _products;

    private Customer _customer;

// =====================================================
// --------------------Constructor ---------------------
// =====================================================

    public Order(
        Customer customer)
    {
        _customer = customer;

        _products = new List<Product>();
    }

// =====================================================
// ---------------Function: Add product ----------------
// =====================================================

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

// =====================================================
// ------- Function: Calculate total price -------------
// =====================================================

    public double CalculateTotalCost()
    {
        double total = 0;

        foreach (Product product in _products)
        {
            total += product.GetTotalCost();
        }

// ----------- Shipping cost -----------

        if (_customer.LivesInUSA())
        {
            total += 5;
        }
        else
        {
            total += 35;
        }

        return total;
    }

// =====================================================
// ------------- Function: Packing label ---------------
// =====================================================

    public string GetPackingLabel()
    {
        string label = "";

        foreach (Product product in _products)
        {
            label +=
                $"Product: {product.GetName()} | ID: {product.GetProductId()}\n";
        }

        return label;
    }

// =====================================================
// ------------- Function: Shipping label--------------- 
// =====================================================

    public string GetShippingLabel()
    {
        return
            $"{_customer.GetName()}\n" +
            $"{_customer.GetAddress().GetFullAddress()}";
    }
}