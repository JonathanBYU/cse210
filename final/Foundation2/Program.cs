using System;

class Program
{
    static void Main(string[] args)
    {
        Product[] productsList1 = [new Product("Zyrtec", 1234, 2.99, 3), new Product("Benadryl", 4321, 5.68, 2)];
        Address address1 = new Address("123 Example Rd.", "Rexburg", "ID", "USA");
        Customer customer1 = new Customer("Jonathan", address1);
        Product[] productsList2 = [new Product("Milk", 1345, 3.50, 2), new Product("Cereal", 4215, 3.99, 1)];
        Address address2 = new Address("321 Example Street", "Atlanta", "GA", "USA");
        Customer customer2 = new Customer("Jordan", address2);
        
        Order[] orders = [new Order(productsList1,customer1), new Order(productsList2,customer2)];
        foreach (Order order in orders)
        {
            Console.WriteLine($"\nPacking Label: {order.GetPackingLabel()}");
            Console.WriteLine($"Shipping Label: {order.GetShippingLabel()}");
            Console.WriteLine($"Total Cost: ${order.GetTotalCost()}");
        }
    }
}