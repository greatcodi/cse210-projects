using System;

class Program
{
    static void Main(string[] args)
    {
        Address order1A = new Address("Romrog", "New Castle", "WY","USA");
        Customer order1C = new Customer("Alexandra Gonzales Mostacera", order1A);
        Order order1 = new Order(order1C);
        // -------------Create the products and add them to the list in Order class
        Product order1P1 = new Product("Coca Cola", 12071994, 2.50, 5);
        Product order1P2 = new Product("Oreo package", 01041996, 3, 2);
        order1.SetProducts(order1P1);
        order1.SetProducts(order1P2);
        // -------------Create the customer and set the customer attribute in order class
        
        
        Console.WriteLine("ORDER:");
        Console.WriteLine ("Packing Label:");
        order1.PackingLabel();
        Console.WriteLine();
        Console.WriteLine("Shipping Label:");
        order1.ShippingLabel();
        Console.WriteLine();
        double totalPrice = order1.TotalCostProducts();
        Console.WriteLine($">---------Total price: ${totalPrice}---------< ");
        Console.WriteLine();
        Console.WriteLine();




        Address order2A = new Address("Los Geranios 663", "San Juan de Lurigancho", "Lima","Peru");
        Customer order2C = new Customer("Angello Ruiz Landauro", order2A);
        Order order2 = new Order(order2C);
        // -------------Create the products and add them to the list in Order class
        Product order2P1 = new Product("Smart TV", 28032022, 1000, 2);
        Product order2P2 = new Product("PS5", 19062000, 1500, 2);
        Product order2P3 = new Product("Chair Gamer", 13081969, 500, 4);
        order2.SetProducts(order2P1);
        order2.SetProducts(order2P2);
        order2.SetProducts(order2P3);
        // -------------Create the customer and set the customer attribute in order class
        
        
        Console.WriteLine("ORDER:");
        Console.WriteLine ("Packing Label:");
        order2.PackingLabel();
        Console.WriteLine();
        Console.WriteLine("Shipping Label:");
        order2.ShippingLabel();
        Console.WriteLine();
        double totalPrice2 = order2.TotalCostProducts();
        Console.WriteLine($">---------Total price: ${totalPrice2}---------< ");
        Console.WriteLine();
        Console.WriteLine();



    }
}