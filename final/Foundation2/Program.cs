using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation2 World!");
        Console.WriteLine("");

        Product product1 = new Product("Product 1", "123", 99.90m, 10);
        Product product2 = new Product("Product 2", "456", 59.99m, 7);

        Address address = new Address("100 Main St", "Provo", "Utah", "USA");

        Customer customer = new Customer("John Smith", address);

        List<Product> products = new List<Product> { product1, product2 };
        Order order = new Order(products, customer);

        Console.WriteLine(order.GetPackingLabel());
        Console.WriteLine(order.GetShippingLabel());
        Console.WriteLine("");
        Console.WriteLine($"Total Price: $ {order.CalculateTotalCost()}");

        Console.ReadLine();


    }
}