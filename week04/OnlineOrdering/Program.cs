using System;

class Program
{
    static void Main(string[] args)
    {
// =====================================================
// ------------------- ORDER 1 (USA) -------------------
// =====================================================

        Address address1 =
            new Address(
                "123 Main Street",
                "New York",
                "NY",
                "USA"
            );


        Customer customer1 =
            new Customer(
                "John Smith",
                address1
            );

        Order order1 =
            new Order(customer1);

        order1.AddProduct(
            new Product(
                "Laptop",
                "P100",
                800,
                1
            )
        );

        order1.AddProduct(
            new Product(
                "Mouse",
                "P200",
                25,
                2
            )
        );

// =====================================================
// ----------------- ORDER 2 (Brazil) ------------------
// =====================================================

        Address address2 =
            new Address(
                "Rua Central 100",
                "Recife",
                "PE",
                "Brazil"
            );

        Customer customer2 =
            new Customer(
                "Juliane Ferreira",
                address2
            );

        Order order2 =
            new Order(customer2);

        order2.AddProduct(
            new Product(
                "Keyboard",
                "P300",
                50,
                1
            )
        );

        order2.AddProduct(
            new Product(
                "Monitor",
                "P400",
                300,
                2
            )
        );

        order2.AddProduct(
            new Product(
                "Webcam",
                "P500",
                80,
                1
            )
        );

// =====================================================
// ------------------ Display Order 1 ------------------
// =====================================================

        Console.WriteLine(
            "======================================"
        );

        Console.WriteLine(
            "ORDER 1"
        );

        Console.WriteLine();

        Console.WriteLine(
            "PACKING LABEL"
        );

        Console.WriteLine(
            order1.GetPackingLabel()
        );

        Console.WriteLine(
            "SHIPPING LABEL"
        );

        Console.WriteLine(
            order1.GetShippingLabel()
        );

        Console.WriteLine(
            $"TOTAL COST: ${order1.CalculateTotalCost()}"
        );

// =====================================================
// ---------------- Display Order 2 -------------------
// =====================================================

        Console.WriteLine();

        Console.WriteLine(
            "======================================"
        );

        Console.WriteLine(
            "ORDER 2"
        );

        Console.WriteLine();

        Console.WriteLine(
            "PACKING LABEL"
        );

        Console.WriteLine(
            order2.GetPackingLabel()
        );

        Console.WriteLine(
            "SHIPPING LABEL"
        );

        Console.WriteLine(
            order2.GetShippingLabel()
        );

        Console.WriteLine(
            $"TOTAL COST: ${order2.CalculateTotalCost()}"
        );
    }
}