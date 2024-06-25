using System;

public class Customer
{
    // Data members/fields
    private int customerId;
    private string name;
    private int age;
    private string phone;
    private string city;

    // Constructor with no arguments
    public Customer()
    {
        customerId = 0;
        name = "Unknown";
        age = 0;
        phone = "N/A";
        city = "N/A";
    }

    // Constructor with all information
    public Customer(int customerId, string name, int age, string phone, string city)
    {
        this.customerId = customerId;
        this.name = name;
        this.age = age;
        this.phone = phone;
        this.city = city;
    }

    // Method to display customer information
    public void DisplayCustomer()
    {
        Console.WriteLine($"Customer ID: {customerId}");
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Age: {age}");
        Console.WriteLine($"Phone: {phone}");
        Console.WriteLine($"City: {city}");
    }

    // Static method to display customer information directly (without object)
    public static void DisplayCustomerStatic(Customer customer)
    {
        if (customer != null)
        {
            Console.WriteLine("Customer Information (Static Method):");
            Console.WriteLine($"Customer ID: {customer.customerId}");
            Console.WriteLine($"Name: {customer.name}");
            Console.WriteLine($"Age: {customer.age}");
            Console.WriteLine($"Phone: {customer.phone}");
            Console.WriteLine($"City: {customer.city}");
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine("Customer object is null.");
            Console.ReadLine();
        }
    }

    // Destructor (Finalizer)
    ~Customer()
    {
        // Perform cleanup actions if needed
        Console.WriteLine($"Customer object with ID {customerId} is being destroyed.");
        Console.ReadLine();
    }
}

class Program
{
    static void Main()
    {
        // Create a customer object using parameterized constructor
        Customer customer1 = new Customer(1, "Deepa", 30, "123-456-7890", "Bangalore");

        // Display customer information using instance method
        Console.WriteLine("Displaying Customer Information (Instance Method):");
        customer1.DisplayCustomer();
        Console.WriteLine();
        Console.ReadLine();

        // Create another customer object using default constructor
        Customer customer2 = new Customer();

        // Display customer information using static method (direct call)
        Console.WriteLine("Displaying Customer Information (Static Method):");
        Customer.DisplayCustomerStatic(customer2);
        Console.WriteLine();
        Console.ReadLine();

        // Demonstrate finalizer (destructor) automatically called by GC
        // Uncomment the next line to see the finalizer in action
        // customer1 = null; // Setting to null triggers GC to finalize

        Console.WriteLine("End of Main method. Program will exit.");
        Console.ReadLine();
    }
}
