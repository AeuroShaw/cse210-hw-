using System;

class Program
{
    static void Main(string[] args)
    {
        // Customer 1 (USA)
        Address address1 = new Address("123 Main St", "New York", "NY", "USA");
        Customer customer1 = new Customer("John Smith", address1);

        Product p1 = new Product("Laptop", "P100", 800, 1);
        Product p2 = new Product("Mouse", "P200", 20, 2);

        Order order1 = new Order(customer1);
        order1.AddProduct(p1);
        order1.AddProduct(p2);

        // Customer 2 (International)
        Address address2 = new Address("45 Market Rd", "Toronto", "ON", "Canada");
        Customer customer2 = new Customer("Jane Doe", address2);

        Product p3 = new Product("Phone", "P300", 600, 1);
        Product p4 = new Product("Headphones", "P400", 50, 2);
        Product p5 = new Product("Charger", "P500", 25, 1);

        Order order2 = new Order(customer2);
        order2.AddProduct(p3);
        order2.AddProduct(p4);
        order2.AddProduct(p5);

        // Display Order 1
        Console.WriteLine("Order 1 Packing Label:");
        Console.WriteLine(order1.GetPackingLabel());

        Console.WriteLine("Order 1 Shipping Label:");
        Console.WriteLine(order1.GetShippingLabel());

        Console.WriteLine($"Total Price: ${order1.GetTotalCost()}");

        Console.WriteLine("\n-----------------\n");

        // Display Order 2
        Console.WriteLine("Order 2 Packing Label:");
        Console.WriteLine(order2.GetPackingLabel());

        Console.WriteLine("Order 2 Shipping Label:");
        Console.WriteLine(order2.GetShippingLabel());

        Console.WriteLine($"Total Price: ${order2.GetTotalCost()}");
    }
}