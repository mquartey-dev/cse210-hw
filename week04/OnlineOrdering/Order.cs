using System;
using System.Collections.Generic;

public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double CalculateTotalCost()
    {
        double total = 0;
        
        // Sum up the cost of all the products
        foreach (Product p in _products)
        {
            total += p.GetTotalCost();
        }

        // Add the appropriate shipping cost
        if (_customer.IsInUSA())
        {
            total += 5.00; // USA shipping
        }
        else
        {
            total += 35.00; // International shipping
        }

        return total;
    }

    public string GetPackingLabel()
    {
        string label = "--- PACKING LABEL ---\n";
        foreach (Product p in _products)
        {
            label += $"- {p.GetProductDetails()}\n";
        }
        return label;
    }

    public string GetShippingLabel()
    {
        string label = "--- SHIPPING LABEL ---\n";
        label += $"{_customer.GetName()}\n";
        label += $"{_customer.GetAddress().GetFullAddress()}";
        return label;
    }
}
