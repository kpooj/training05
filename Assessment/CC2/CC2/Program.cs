
using System.Linq;
using System;

public class Product
{
    public int ProductId { get; set; }
    public string ProductName { get; set; }
    public decimal Price { get; set; }
}

public class Program
{
    public static void Main()
    {
        // Array to hold 10 products
        Product[] products = new Product[10];

        // Accepting input for each product
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"Enter details for Product  we want {i + 1}:");

            Product product = new Product();
            product.ProductId = i + 1;

            Console.Write(" Details of the Product Name: ");
            product.ProductName = Console.ReadLine();

            bool validPrice = false;
            while (!validPrice)
            {
                Console.Write(" Price of each product: ");
                string input = Console.ReadLine();

                // Try parsing the input as a decimal
                if (decimal.TryParse(input, out decimal price) && price > 0)
                {
                    product.Price = price;
                    validPrice = true;
                }
                else
                {
                    Console.WriteLine("Invalid input. Price must be a positive number.");
                }
            }

            products[i] = product;
        }

        
        var sortedProducts = products.OrderBy(p => p.Price);

        // Displaying sorted products
        Console.WriteLine("\nSorted Products based on Price:");
        foreach (var product in sortedProducts)
        {
            Console.WriteLine($"Product ID: {product.ProductId}, Product Name: {product.ProductName}, Price: {product.Price:C}");
        }
    }
}
