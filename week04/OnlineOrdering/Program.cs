using System;

class Program
{
    static void Main(string[] args)
    {
        // --- ORDER 1: USA CUSTOMER ---
        Address address1 = new Address("123 Maple St", "Springfield", "IL", "USA");
        Customer customer1 = new Customer("John Doe", address1);
        Order order1 = new Order(customer1);
        
        order1.AddProduct(new Product("Wireless Mouse", "M100", 25.99, 2));
        order1.AddProduct(new Product("Mechanical Keyboard", "K200", 89.50, 1));

        // --- ORDER 2: INTERNATIONAL CUSTOMER ---
        Address address2 = new Address("456 Oak Rd", "Toronto", "ON", "Canada");
        Customer customer2 = new Customer("Jane Smith", address2);
        Order order2 = new Order(customer2);
        
        order2.AddProduct(new Product("USB-C Hub", "H300", 45.00, 1));
        order2.AddProduct(new Product("Laptop Stand", "S400", 35.99, 1));
        order2.AddProduct(new Product("HD Webcam", "W500", 59.99, 1));

        // --- DISPLAY ORDER 1 ---
        Console.WriteLine("==============================");
        Console.WriteLine("           ORDER 1            ");
        Console.WriteLine("==============================");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine();
        Console.WriteLine(order1.GetShippingLabel());
        // Formatting to ":0.00" ensures it prints like money (e.g. $146.48)
        Console.WriteLine($"\nTotal Price: ${order1.CalculateTotalCost():0.00}\n"); 

        // --- DISPLAY ORDER 2 ---
        Console.WriteLine("==============================");
        Console.WriteLine("           ORDER 2            ");
        Console.WriteLine("==============================");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine();
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"\nTotal Price: ${order2.CalculateTotalCost():0.00}\n");
    }
}
